using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;

namespace BeerRecipe
{
   public partial class Malt : Form
   {
      Dictionary<string, Dictionary<string, Classes.MaltType>> _malts;

      private List<Classes.MaltType> _all;
      private List<Classes.MaltType> _filteredList;

      public string GrainListFile { get; set; }
      public Classes.MaltType SelectedMalt { get; private set; }

      public Malt()
      {
         InitializeComponent();
         _all = new List<Classes.MaltType>();
         _filteredList = new List<Classes.MaltType>();
         SelectedMalt = null;
      }

      private void Malt_Load(object sender, EventArgs e)
      {
#if DEBUG
         this.Text = this.Text + " [DEBUG]";
#endif
         if (!System.IO.File.Exists(GrainListFile))
         {
            MessageBox.Show(this, "The Grain List File is missing - please set it.", "Problems detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
         }
         string error;
         //_malts = Classes.Util.LoadMalts(@"E:\Data\Desktop\malttyper.xlsx", out error);
         //_malts = Classes.Util.LoadMalts(@"malttyper.xlsx", out error);

         _malts = Classes.Util.LoadMalts_EEPLUS(GrainListFile, out error);
         if (!string.IsNullOrEmpty(error))
         {
            MessageBox.Show(this, error, "Feil ved last av malt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
         }

         if (_malts.Count > 0)
         {
            txtPercentageAmount.Text = Properties.Settings.Default.Malt_Percentage.ToString("0.00", CultureInfo.CurrentCulture);

            string malt_liste = Properties.Settings.Default.Malt_List;
            cboMaltLister.Items.Clear();
            int i = 0;
            int index = 0;
            foreach (var item in _malts)
            {
               cboMaltLister.Items.Add(item.Key);
               if (malt_liste.Equals(item.Key))
               {
                  index = i;
               }
               i++;
            }
            // The next call will trigger the event OnSelectedIndexChanged, which in turn will invoke method PopulateListView
            cboMaltLister.SelectedIndex = index;

            txtFilter.Text = Properties.Settings.Default.Malt_Filter;
         }

         OnTextChanged(txtPercentageAmount, null);
         txtFilter.Focus();
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
         double value;
         if (Classes.Util.ValidDouble(txtPercentageAmount.Text, out value) && listView1.SelectedIndices.Count > 0)
         {
            SelectedMalt = new Classes.MaltType(_filteredList[listView1.SelectedIndices[0]]);
            SelectedMalt.MengdeProsent = value;

            Properties.Settings.Default.Malt_Filter = txtFilter.Text;
            Properties.Settings.Default.Malt_List = cboMaltLister.Text;
            Properties.Settings.Default.Malt_Percentage = value;
            Properties.Settings.Default.Save();

            DialogResult = DialogResult.OK;
         }
      }

      private void OnSelectedIndexChanged(object sender, EventArgs e)
      {
         ComboBox cb = sender as ComboBox;
         if (null != cb)
         {
            try
            {
               PopulateListView(cboMaltLister.SelectedItem.ToString());
            }
            catch { }
         }
         ConsolidateOkBtn();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
      }

      private void PopulateListView(string sheet)
      {
         if (!_malts.ContainsKey(sheet))
         {
            return;
         }
         if (listView1.Tag is string)
         {
            if (listView1.Tag.ToString().Equals(sheet, StringComparison.OrdinalIgnoreCase))
            {
               // Already populated
               return;
            }
         }
         listView1.Items.Clear();
         foreach (var fane in _malts)
         {
            if (!fane.Key.Equals(sheet))
            {
               continue;
            }

            _all.Clear();
            _filteredList.Clear();
            foreach (var item in fane.Value)
            {
               _all.Add(item.Value);
               _filteredList.Add(item.Value);
            }
            SetupListView();
            listView1.Tag = sheet;

            RefreshFilter();
            break;
         }
      }

      private void SetupListView()
      {
         PropertyInfo aProp = typeof(ListView).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
         aProp.SetValue(listView1, true, null);

         // This makes it real fast!!
         listView1.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(ListView_RetrieveVirtualItem);
         listView1.VirtualListSize = _filteredList.Count;
         listView1.VirtualMode = true;
      }

      private void ListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
      {
         ListViewItem lvi = new ListViewItem(new string[]
         {
             _filteredList[e.ItemIndex].Malttype
            ,_filteredList[e.ItemIndex].Malteri
            ,_filteredList[e.ItemIndex].Kornsort
            ,_filteredList[e.ItemIndex].ME.ToString("0.00")
            ,_filteredList[e.ItemIndex].Enzymaktivitet
            ,_filteredList[e.ItemIndex].Fargebidrag
            ,_filteredList[e.ItemIndex].AnbefaltMengde
            ,_filteredList[e.ItemIndex].Smaksbidrag
            ,_filteredList[e.ItemIndex].Bruksområde
            ,_filteredList[e.ItemIndex].Kommentar
         });
         e.Item = lvi;
      }

      private void txtFilter_TextChanged(object sender, EventArgs e)
      {
         TextBox tb = sender as TextBox;
         if (null != tb)
         {
            if (string.IsNullOrEmpty(tb.Text))
            {
               if (_filteredList.Count < _all.Count)
               {
                  listView1.VirtualListSize = 0;
                  _filteredList.Clear();
                  for (int i = 0; i < _all.Count; i++)
                  {
                     _filteredList.Add(_all[i]);
                  }
                  listView1.VirtualListSize = _filteredList.Count;
                  listView1.Invalidate();
               }
            }
            else
            {
               listView1.VirtualListSize = 0;
               _filteredList.Clear();

               Func<string, string, bool> comparer = (x, y) => chkFilterStartsWith.Checked ? x.StartsWith(y, StringComparison.OrdinalIgnoreCase) : x.ToLower().Contains(y.ToLower());
               foreach (var item in _all)
               {
                  if (comparer(item.Malttype, tb.Text))
                  {
                     _filteredList.Add(item);
                  }
               }
               listView1.VirtualListSize = _filteredList.Count;
               listView1.Invalidate();
            }
         }
      }

      private void chkFilterStartsWith_CheckedChanged(object sender, EventArgs e)
      {
         RefreshFilter();
      }

      private void RefreshFilter()
      {
         string oldVal = txtFilter.Text;
         txtFilter.Text = "";
         txtFilter.Text = oldVal;
      }

      private void OnTextChanged(object sender, EventArgs e)
      {
         TextBox tb = sender as TextBox;
         if (null != tb)
         {
            if (txtPercentageAmount == tb)
            {
               double val = 0;
               bool setError = true;
               if (Classes.Util.ValidDouble(txtPercentageAmount.Text, out val))
               {
                  if ((val <= 100) && (val >= 0))
                  {
                     setError = false;
                  }
               }
               errorProvider1.SetError(tb, setError ? "Du må sette inn et tall i intervall [0 - 100] (%)" : "");
               ConsolidateOkBtn();
            }
         }
      }

      private void OnEnter(object sender, EventArgs e)
      {
         TextBox tb = sender as TextBox;
         if (null != tb)
         {
            tb.SelectAll();
         }
      }
      //if (Classes.Util.ValidDouble(tb.Text))
      private void OnLeave(object sender, EventArgs e)
      {
         TextBox tb = sender as TextBox;
         if (txtPercentageAmount == tb)
         {
            double val;
            if (Classes.Util.ValidDouble(txtPercentageAmount.Text, out val))
            {
               txtPercentageAmount.Text = val.ToString("0.00", CultureInfo.CurrentCulture);
            }
         }
      }

      //private bool ValidDouble(object sender, out double val)
      //{
      //   val = 0;
      //   bool ret = false;
      //   TextBox tb = sender as TextBox;
      //   string tmp = tb.Text.Replace(',', '.');
      //   if (double.TryParse(tmp, out val))
      //   {
      //      ret = true;
      //   }
      //   return ret;
      //}

      private void ConsolidateOkBtn()
      {
         try
         {
            btnOK.Enabled = (errorProvider1.GetError(txtPercentageAmount).Length == 0) && (null != listView1.SelectedIndices) && (listView1.SelectedIndices.Count > 0);
         }
         catch { btnOK.Enabled = false; }
      }
   }
}
