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
   public partial class Form2 : Form
   {
      List<KeyValuePair<TextBox, KeyValuePair<string, string>>> _textboxBindings;
      Classes.Recipe _recipe;

      public Form2()
      {
         InitializeComponent();

         _textboxBindings = new List<KeyValuePair<TextBox, KeyValuePair<string, string>>>();

         _recipe = new Classes.Recipe();
         _recipe.BatchVolum = Properties.Settings.Default.Recipe_BatchVolum;
         _recipe.FermenterTrubLoss = Properties.Settings.Default.Recipe_FermenterTrubLoss;
         _recipe.KettleLoss = Properties.Settings.Default.Recipe_KettleLoss;
         _recipe.OriginalGravity = Properties.Settings.Default.Recipe_OriginalGravity;
         _recipe.BoilTime = Properties.Settings.Default.Recipe_BoilTime;
         _recipe.BoilOfRate = Properties.Settings.Default.Recipe_BoilOfRate;
         _recipe.BHE = Properties.Settings.Default.Recipe_BHE;
         _recipe.WaterLossInGrain = Properties.Settings.Default.Recipe_WLIG;
         _recipe.WGR = Properties.Settings.Default.Recipe_WGR;
         _recipe.AdjustForVolTempChangeInWater = Properties.Settings.Default.Recipe_AdjustForVolTempChangeInWater;
         _recipe.KeyPropertyChanged += _recipe_KeyPropertyChanged;
      }

      private void _recipe_KeyPropertyChanged(string propertyName)
      {
         if (!string.IsNullOrEmpty(propertyName))
         {
            System.Diagnostics.Trace.WriteLine("_recipe_KeyPropertyChanged: " + propertyName);

            switch (propertyName)
            {
               case "OriginalGravity":
               case "BatchVolum":
               case "BHE":
               case "FermenterTrubLoss":
               case "KettleLoss":
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
               //if (Classes.Calulator.GetMaltAmountByPercentage(item.Value.MengdeProsent / 100.0, item.Value.ME / 100.0, _recipe.BHE / 100.0, _recipe.OriginalGravity, _recipe.BatchVolum, out malt_amount))
               if (Classes.Calulator.GetMaltAmountByPercentage(item.Value.MengdeProsent / 100.0, item.Value.ME / 100.0, _recipe.BHE / 100.0, _recipe.OriginalGravity, _recipe.BatchVolum + _recipe.FermenterTrubLoss + _recipe.KettleLoss, out malt_amount))
               {
                  item.Value.Mengde = malt_amount;
                  _recipe.ReplaceMalt(new Classes.MaltType(item.Value));
               }
            }
         }
      }

      private void test()
      {
         double dd = 2.14159;
         string tt = string.Format("The Slider value is {0:F3}", dd);

         int aaaaa = 0b1010;
         int bbbbb = 0b0010_0110_0000_0011;
         int ccccc = 0b0010011000000011;
         int h1 = 0xff_ff;
         int h2 = 0xffff;
         aaaaa = aaaaa + 0;
         bbbbb = bbbbb + 0;
         ccccc = ccccc + 0;
         h1 = h1 + 0;
         h2 = h2 + 0;
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         test();
#if DEBUG
         this.Text = this.Text + " [DEBUG]";
#endif
         this.toolTip2.SetToolTip(this.txtKokevolum, "Denne er beregnet på følgende måte:" + System.Environment.NewLine + "\"Ønsket sluttvolum\" + ((\"Koketid\" / 60) * \"Avdamping\")");
         this.toolTip2.SetToolTip(this.txtMaltMengde, "Denne er beregnet på følgende måte:" + System.Environment.NewLine + "∑(mengde av de ulike kornsorter en har lagt til i oppskriften)");
         this.toolTip2.SetToolTip(this.txtMeskevolum, "Denne er beregnet på følgende måte:" + System.Environment.NewLine + "\"Maltmengde\" * \"Vann/malt forhold\"");
         this.toolTip2.SetToolTip(this.txtSkyllevann, "Denne er beregnet på følgende måte:" + System.Environment.NewLine + "(\"Kokevolum\" - (\"Vann/malt forhold\" * \"Maltmengde\")) + (\"Mesketap\" * \"Maltmengde\")");
         this.toolTip2.SetToolTip(this.txtSG, "Denne er beregnet på følgende måte:" + System.Environment.NewLine + "1 + [{(\"Ønsket OG\" - 1.0) * \"Ønsket sluttvolum\"} / \"Kokevolum\"]");
         this.toolTip2.SetToolTip(this.lblTrubLoss, "Fermenter trub loss" + System.Environment.NewLine + "The fermenter trub loss is the amount of liquid and trub remaining in the fermenter after transferring to either secondary, bottles or kegs."
          + System.Environment.NewLine + "If transferring to a secondary, any trub loss in the secondary should also be added to the primary fermenter trub loss."
          + System.Environment.NewLine + "The trub loss will vary both due to your equipment, and also the amount of hops used, the yeast and if you dry hopped or not."
          + System.Environment.NewLine + "If you haven't measured your actual trub loss, let the default value of 2.00 litres remain here until you have made some actual measurements.");
         this.toolTip2.SetToolTip(this.lblKettleLoss, "Kettle loss"
          + System.Environment.NewLine + "The total volume of liquid left in the boiling kettle after transfer to the fermentor."
          + System.Environment.NewLine + "This depends on the deadspace in the boiling kettle, and also the amount of trub that will vary depending on the hop amount used.");

         this.toolTip2.SetToolTip(this.lblEstimatedSG, "Estimert SG en bør ha i mesken rett før koking for å oppnå målsatt OG."
            + System.Environment.NewLine + "En kan på dette tidspunktet justere SG slik at en oppnår OG."
            + System.Environment.NewLine + "Formel (i GU): OG * (Vpost / Vpre)"
            + System.Environment.NewLine + "hvor"
            + System.Environment.NewLine + "   GU    = Gravity Units (alt. gravity points. Hvis OG = 1,062 er GU = 62)"
            + System.Environment.NewLine + "   Vpost = Volum etter koking"
            + System.Environment.NewLine + "   Vpre  = Volum før koking");

         
         this.toolTip2.SetToolTip(this.chkAdjustForVolTempChangeInWater, "Når kokevolumet skal beregnes kan en ta høyde for at 1 liter vann @100°C har ca. 4 % større volum enn hva det har @20°C."
            + System.Environment.NewLine + "Haker en av denne vil programmet ta dette med i beregningen av kokevolumet.");


         this.toolTip2.SetToolTip(this.lblEvaporation, "Evaporation per hour"
            + System.Environment.NewLine + "The total volume that evaporates due to boiling per hour."
            + System.Environment.NewLine + ""
            + System.Environment.NewLine + "This usually does not vary much upon the batch size, but the diameter of the kettle, the vigor of"
            + System.Environment.NewLine + "the boil and to some extent the environment."
            + System.Environment.NewLine + ""
            + System.Environment.NewLine + "Trial and error is usually necessary to find the actual Evaporation rate of your equipment."
            + System.Environment.NewLine + "If you are unsure, 4.50 litres should be a good starting point.");

         this.toolTip2.SetToolTip(this.lblBHE, "Mash efficiency (Brew House Efficiency - BHE)"
            + System.Environment.NewLine + "The mash efficiency tells us how much of the sugars in the grain that gets extracted during the mash"
            + System.Environment.NewLine + "and sparge steps, and gives us the basics to estimate the pre-boil gravity of your brew."
            + System.Environment.NewLine + ""
            + System.Environment.NewLine + "This property depends upon your equipment and process, and should be measured when you brew to find a"
            + System.Environment.NewLine + "good average for your setup."
            + System.Environment.NewLine + ""
            + System.Environment.NewLine + "If you don't know the mash efficiency of your equipment, 81 % is a good value to use as a starting"
            + System.Environment.NewLine + "point (between 60-80%, typically 75%).");

         toolTip2.IsBalloon = true;
         toolTip2.UseFading = true;
         toolTip2.AutoPopDelay = 20000;

         tsslTotalVolum.Text = "--";

         // Prepare the textboxes that will be 2-way data bounded to a given property in _recipe.
         // The first section configures textboxes that are bound to not dependent properties (it's only allowed to bind to properties)
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtSluttVolum, new KeyValuePair<string, string>("BatchVolum", "0.0")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtTrubLoss, new KeyValuePair<string, string>("FermenterTrubLoss", "0.0")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtKettleLoss, new KeyValuePair<string, string>("KettleLoss", "0.0")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtOG, new KeyValuePair<string, string>("OriginalGravity", "0.0000")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtKoketid, new KeyValuePair<string, string>("BoilTime", "0")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtEvaporation, new KeyValuePair<string, string>("BoilOfRate", "0.00")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtBHE, new KeyValuePair<string, string>("BHE", "0")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtMesketap, new KeyValuePair<string, string>("WaterLossInGrain", "0.00")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtWGR, new KeyValuePair<string, string>("WGR", "0.00")));

         // These properties are dependent upon one or several other properties - these are special and will not fire the NotifyPropertyChanged event
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtKokevolum, new KeyValuePair<string, string>("BoilVolum", "0.00")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtMaltMengde, new KeyValuePair<string, string>("MaltAmount", "0.00")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtMeskevolum, new KeyValuePair<string, string>("StrikeVolum", "0.00")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtSkyllevann, new KeyValuePair<string, string>("SpargeVolum", "0.00")));
         _textboxBindings.Add(new KeyValuePair<TextBox, KeyValuePair<string, string>>(txtSG, new KeyValuePair<string, string>("SpecificGravity", "0.000")));

         // Configure the data bindings
         foreach (var item in _textboxBindings)
         {
            item.Key.DataBindings.Add("Text", _recipe, item.Value.Key, true, DataSourceUpdateMode.OnPropertyChanged, 0, item.Value.Value, CultureInfo.CurrentCulture);
            item.Key.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidating);
            item.Key.Validated += new System.EventHandler(this.OnValidated);
         }

         chkAdjustForVolTempChangeInWater.DataBindings.Add("Checked", _recipe, "AdjustForVolTempChangeInWater", false, DataSourceUpdateMode.OnPropertyChanged);
         cbFrom.SelectedIndex = 1;
         btnConvert_Click(null, null);
      }

      private void OnFormClosing(object sender, FormClosingEventArgs e)
      {
         Properties.Settings.Default.Recipe_BatchVolum = _recipe.BatchVolum;
         Properties.Settings.Default.Recipe_FermenterTrubLoss = _recipe.FermenterTrubLoss;
         Properties.Settings.Default.Recipe_KettleLoss = _recipe.KettleLoss;
         Properties.Settings.Default.Recipe_OriginalGravity = _recipe.OriginalGravity;
         Properties.Settings.Default.Recipe_BoilTime = _recipe.BoilTime;
         Properties.Settings.Default.Recipe_BoilOfRate = _recipe.BoilOfRate;
         Properties.Settings.Default.Recipe_BHE = _recipe.BHE;
         Properties.Settings.Default.Recipe_WLIG = _recipe.WaterLossInGrain;
         Properties.Settings.Default.Recipe_WGR = _recipe.WGR;
         Properties.Settings.Default.Recipe_AdjustForVolTempChangeInWater = _recipe.AdjustForVolTempChangeInWater;
         Properties.Settings.Default.Save();
      }

      private void OnValidating(object sender, CancelEventArgs e)
      {
         TextBox tb = sender as TextBox;
         if (null != tb)
         {
            foreach (var item in _textboxBindings)
            {
               if (tb == item.Key)
               {
                  //NumberFormatInfo current1 = CultureInfo.CurrentCulture.NumberFormat;
                  //string val = tb.Text.Replace(current1.NumberDecimalSeparator, "");
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
            foreach (var item in _textboxBindings)
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
               //if (Classes.Calulator.GetMaltAmountByPercentage(f.SelectedMalt.MengdeProsent / 100.0, f.SelectedMalt.ME / 100.0, _recipe.BHE / 100.0, _recipe.OriginalGravity, _recipe.BatchVolum, out malt_amount))
               if (Classes.Calulator.GetMaltAmountByPercentage(f.SelectedMalt.MengdeProsent / 100.0, f.SelectedMalt.ME / 100.0, _recipe.BHE / 100.0, _recipe.OriginalGravity, _recipe.BatchVolum + _recipe.FermenterTrubLoss + _recipe.KettleLoss, out malt_amount))
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
         if (_recipe.GetMalts().Count > 0)
         {
            _recipe.ClearMalts();
            tsslTotalVolum.Text = "--";
            tsslTotalVolum.ForeColor = Color.Black;
            double d = _recipe.BatchVolum;
            _recipe.BatchVolum = 0;
            _recipe.ForceUpdate = true;
            _recipe.BatchVolum = d;
            _recipe.ForceUpdate = false;
         }
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
               , Classes.Calulator.GetPointsPoundGallon_PGG(m.Value.ME).ToString("0", CultureInfo.CurrentCulture)
               , Classes.Calulator.GetPotential(m.Value.ME).ToString("0.000", CultureInfo.CurrentCulture)
               , Classes.Calulator.GetPlatoAdvanced(m.Value.ME).ToString("0.0", CultureInfo.CurrentCulture)
            });
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
                  ModifyHelper mh = new ModifyHelper(new Classes.MaltType(malt), _recipe.BHE / 100.0, _recipe.OriginalGravity, _recipe.BatchVolum + _recipe.FermenterTrubLoss + _recipe.KettleLoss);
                  ModifyItem mi = new ModifyItem(mh);
                  DialogResult ret = mi.ShowDialog();
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
