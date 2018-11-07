using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BeerRecipe
{
   public partial class Form1 : Form
   {
      List<KeyValuePair<TextBox, KeyValuePair<string, string>>> _values2;
      Classes.Recipe _recipe;

      public Form1()
      {
         InitializeComponent();
         _values2 = new List<KeyValuePair<TextBox, KeyValuePair<string, string>>>();
         _recipe = new Classes.Recipe();

         _recipe.BatchVolum = Properties.Settings.Default.Recipe_BatchVolum;
         _recipe.OriginalGravity = Properties.Settings.Default.Recipe_OriginalGravity;
         _recipe.BoilTime = Properties.Settings.Default.Recipe_BoilTime;
         _recipe.BoilOfRate = Properties.Settings.Default.Recipe_BoilOfRate;
         _recipe.BHE = Properties.Settings.Default.Recipe_BHE;
         _recipe.WaterLossInGrain = Properties.Settings.Default.Recipe_WLIG;
         _recipe.WGR = Properties.Settings.Default.Recipe_WGR;

         _recipe.KeyPropertyChanged += _recipe_KeyPropertyChanged;
         double og;
         Classes.Calulator.GetOriginalGravity(3.63, 0.5, 0.8, 0.75, 25.0, out og);
      }

      private void _recipe_KeyPropertyChanged(string propertyName)
      {
         if (!string.IsNullOrEmpty(propertyName))
         {
            System.Diagnostics.Trace.WriteLine(propertyName);

            switch (propertyName)
            {
               case "OriginalGravity":
               case "BatchVolum":
               case "BHE":
                  RecalculateGrains();
                  UpdateControls();
                  break;
               default:
                  break;
            }
         }
      }

      private void RecalculateGrains()
      {
         if ((null != _recipe) && _recipe.ContainsMalt())
         {
            Dictionary<string, Classes.MaltType> malts = _recipe.GetMalts();
            foreach (var item in malts)
            {
               double malt_amount;
               if (Classes.Calulator.GetMaltAmountByPercentage(item.Value.MengdeProsent / 100.0, item.Value.ME / 100.0, _recipe.BHE / 100.0, _recipe.OriginalGravity, _recipe.BatchVolum, out malt_amount))
               {
                  item.Value.Mengde = malt_amount;
                  _recipe.ReplaceMalt(new Classes.MaltType(item.Value));
               }
            }
         }
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         this.toolTip2.SetToolTip(this.txtKokevolum, "Denne er beregnet på følgende måte:" + System.Environment.NewLine + "\"Ønsket sluttvolum\" + ((\"Koketid\" / 60) * \"Avdamping\")");
         this.toolTip2.SetToolTip(this.txtMaltMengde, "Denne er beregnet på følgende måte:" + System.Environment.NewLine + "∑(mengde av de ulike kornsorter en har lagt til i oppskriften)");
         this.toolTip2.SetToolTip(this.txtMeskevolum, "Denne er beregnet på følgende måte:" + System.Environment.NewLine + "\"Maltmengde\" * \"Vann/malt forhold\"");
         this.toolTip2.SetToolTip(this.txtSkyllevann, "Denne er beregnet på følgende måte:" + System.Environment.NewLine + "(\"Kokevolum\" - (\"Vann/malt forhold\" * \"Maltmengde\")) + (\"Mesketap\" * \"Maltmengde\")");
         this.toolTip2.SetToolTip(this.txtSG, "Denne er beregnet på følgende måte:" + System.Environment.NewLine + "1 + [{(\"Ønsket OG\" - 1.0) * \"Ønsket sluttvolum\"} / \"Kokevolum\"]");


         toolTip2.IsBalloon = true;
         toolTip2.UseFading = true;
         toolTip2.AutoPopDelay = 20000;

         tsslTotalVolum.Text = "--";

         // Prepare the textboxes that will be 2-way data bounded to a given property in _recipe.
         // The first section configures textboxes that are bound to not dependent properties (it's only allowed to bind to properties)
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtSluttVolum, new KeyValuePair<string, string>("BatchVolum", "0.0")));
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtOG, new KeyValuePair<string, string>("OriginalGravity", "0.0000")));
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtKoketid, new KeyValuePair<string, string>("BoilTime", "0")));
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtEvaporation, new KeyValuePair<string, string>("BoilOfRate", "0.00")));
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtBHE, new KeyValuePair<string, string>("BHE", "0")));
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtMesketap, new KeyValuePair<string, string>("WaterLossInGrain", "0.00")));
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtWGR, new KeyValuePair<string, string>("WGR", "0.00")));

         // These properties are dependent upon one or several other properties - these are special and will not fire the NotifyPropertyChanged event
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtKokevolum, new KeyValuePair<string, string>("BoilVolum", "0.00")));
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtMaltMengde, new KeyValuePair<string, string>("MaltAmount", "0.00")));
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtMeskevolum, new KeyValuePair<string, string>("StrikeVolum", "0.00")));
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtSkyllevann, new KeyValuePair<string, string>("SpargeVolum", "0.00")));
         _values2.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtSG, new KeyValuePair<string, string>("SpecificGravity", "0.000")));

         // Configure the data bindings
         foreach (var item in _values2)
         {
            item.Key.DataBindings.Add("Text", _recipe, item.Value.Key, true, DataSourceUpdateMode.OnPropertyChanged, 0, item.Value.Value, CultureInfo.CurrentCulture);
            item.Key.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidating);
            item.Key.Validated += new System.EventHandler(this.OnValidated);
         }

         cbFrom.SelectedIndex = 1;
         btnConvert_Click(null, null);
      }

      private void OnFormClosing(object sender, FormClosingEventArgs e)
      {
         Properties.Settings.Default.Recipe_BatchVolum = _recipe.BatchVolum;
         Properties.Settings.Default.Recipe_OriginalGravity = _recipe.OriginalGravity;
         Properties.Settings.Default.Recipe_BoilTime = _recipe.BoilTime;
         Properties.Settings.Default.Recipe_BoilOfRate = _recipe.BoilOfRate;
         Properties.Settings.Default.Recipe_BHE = _recipe.BHE;
         Properties.Settings.Default.Recipe_WLIG = _recipe.WaterLossInGrain;
         Properties.Settings.Default.Recipe_WGR = _recipe.WGR;
         Properties.Settings.Default.Save();
      }

      private void OnValidating(object sender, CancelEventArgs e)
      {
         TextBox tb = sender as TextBox;
         if (null != tb)
         {
            foreach (var item in _values2)
            {
               if (tb == item.Key)
               {
                  if (Classes.Util.ValidDouble(tb.Text))
                  {
                     errorProvider1.SetError(tb, "");
                  }
                  else
                  {
                     e.Cancel = true;
                     errorProvider1.SetError(tb, "Satt verdi er ikke gyldig.");
                  }
                  break;
               }
            }
         }
      }

      private void OnValidated(object sender, EventArgs e)
      {
         TextBox tb = sender as TextBox;
         if (null != tb)
         {
            foreach (var item in _values2)
            {
               if (tb == item.Key)
               {
                  tb.DataBindings["Text"].ReadValue();
                  break;
               }
            }
         }
      }

      private void OnAddItem(object sender, EventArgs e)
      {
         Malt f = new Malt();
         DialogResult ret = f.ShowDialog();
         if (ret == DialogResult.OK)
         {
            if ((null != f.SelectedMalt) && f.SelectedMalt.ParsedOk && (f.SelectedMalt.MengdeProsent > 0) && (f.SelectedMalt.MengdeProsent <= 100))
            {
               double malt_amount;
               if (Classes.Calulator.GetMaltAmountByPercentage(f.SelectedMalt.MengdeProsent / 100.0, f.SelectedMalt.ME / 100.0, _recipe.BHE / 100.0, _recipe.OriginalGravity, _recipe.BatchVolum, out malt_amount))
               {
                  f.SelectedMalt.Mengde = malt_amount;
               }

               if (_recipe.ContainsMalt(f.SelectedMalt))
               {
                  _recipe.ReplaceMalt(f.SelectedMalt);
               }
               else
               {
                  _recipe.AddMalt(f.SelectedMalt);
               }
               UpdateControls();
            }
         }
      }

      private void OnDeleteItem(object sender, EventArgs e)
      {
         if (listView1.SelectedIndices.Count > 0)
         {
            if (listView1.Items[listView1.SelectedIndices[0]].Tag is string)
            {
               string key = listView1.Items[listView1.SelectedIndices[0]].Tag as string;
               if (_recipe.ContainsMalt(key))
               {
                  _recipe.RemoveMalt(key);
                  UpdateControls();
               }
            }
         }
      }

      private void OnClearItems(object sender, EventArgs e)
      {
         listView1.Items.Clear();
         _recipe = new Classes.Recipe();
         tsslTotalVolum.Text = "--";
         tsslTotalVolum.ForeColor = Color.Black;
      }

      private void UpdateControls()
      {
         listView1.Items.Clear();

         _recipe.CalculateAmount();
         Dictionary<string, Classes.MaltType> malts = _recipe.GetMalts();
         double tot_percent_amt = 0;
         foreach (var m in malts)
         {
            ListViewItem lvi = new ListViewItem(new string[] 
            {
               m.Value.Mengde.ToString("0.00", CultureInfo.CurrentCulture) + " kg (" + m.Value.MengdeProsent.ToString("0.00", CultureInfo.CurrentCulture) + " %)"
               , m.Value.Malttype + " [" + m.Value.Fargebidrag.ToString() + " EBC (L°)]"
               , m.Value.ME.ToString("0.00", CultureInfo.CurrentCulture)
               , (46.0 * (m.Value.ME / 100.0)).ToString("0", CultureInfo.CurrentCulture) }
            );
            lvi.Tag = m.Key;
            listView1.Items.Add(lvi);
            tot_percent_amt += m.Value.MengdeProsent;
         }

         txtMaltMengde.Text = _recipe.MaltAmount.ToString("0.00");
         tsslTotalVolum.Text = (tot_percent_amt / 100.0).ToString("0.00%");
         tsslTotalVolum.ForeColor = (tot_percent_amt > 100) ? Color.Red : Color.Black;
         if (malts.Count == 0)
         {
            tsslTotalVolum.Text = "--";
         }
      }

      private void OnDoubleClicked(object sender, EventArgs e)
      {
         ListView lv = sender as ListView;
         if ((listView1 == lv) && (lv.SelectedIndices.Count > 0))
         {
            ListViewItem lvi = lv.Items[lv.SelectedIndices[0]];
            if (lvi.Tag is string)
            {
               Classes.MaltType malt;
               if (_recipe.GetMalt(lvi.Tag.ToString(), out malt))
               {
                  ModifyHelper mh = new ModifyHelper(new Classes.MaltType(malt), _recipe.BHE / 100.0, _recipe.OriginalGravity, _recipe.BatchVolum);
                  ModifyItem mi = new ModifyItem(mh);
                  DialogResult ret =  mi.ShowDialog();
                  if ((ret == DialogResult.OK) && !malt.Equals(mi.ValgtMalt.Malt))
                  {
                     _recipe.ReplaceMalt(mi.ValgtMalt.Malt);
                     UpdateControls();
                  }
               }
            }
         }
      }

      private void btnConvert_Click(object sender, EventArgs e)
      {
         if (cbFrom.SelectedIndex == 1)
         {
            // T(°C) = (T(°F) - 32) × 5/9

            double val;
            if (double.TryParse(txtVal_In.Text, out val))
            {
               txtVal_Out.Text = ((val - 32.0) * (5.0 / 9.0)).ToString("0.00");
            }
         }
         else
         {
            // T(°F) = T(°C) × 9/5 + 32
            double val;
            if (double.TryParse(txtVal_In.Text, out val))
            {
               txtVal_Out.Text = (val * (9.0 / 5.0) + 32.0).ToString("0.00");
            }
         }
      }

      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         lblConvertTo.Text = (cbFrom.SelectedIndex != 1) ? "°F" : "°C";
      }
   }
}
