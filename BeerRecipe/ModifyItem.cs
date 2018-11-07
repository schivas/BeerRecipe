using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerRecipe
{
   public partial class ModifyItem : Form
   {

      ModifyHelper _ValgtMalt;
      public ModifyHelper ValgtMalt
      {
         get { return _ValgtMalt; }
         set { _ValgtMalt = value; SetValues(); }
      }

      public ModifyItem()
      {
         InitializeComponent();
      }

      public ModifyItem(ModifyHelper malt)
         : this()
      {
         ValgtMalt = malt;
      }

      private void OnValidating(object sender, CancelEventArgs e)
      {
         TextBox tb = sender as TextBox;
         if (null != tb)
         {
            if (Classes.Util.ValidDouble(tb.Text))
            {
               errorProvider1.SetError(tb, "");
               btnOK.Enabled = Classes.Util.ValidDouble(txtMengdeKg.Text) && Classes.Util.ValidDouble(txtMengdePercent.Text);
            }
            else
            {
               e.Cancel = true;
               errorProvider1.SetError(tb, "Satt verdi er ikke gyldig.");
               btnOK.Enabled = false;
            }
         }
      }

      private void ModifyItem_Load(object sender, EventArgs e)
      {
         SetValues();
      }

      private void SetValues()
      {
         if ((ValgtMalt != null) && (ValgtMalt.Malt != null))
         {
            lblMalttype.Text = ValgtMalt.Malt.Malttype;
            txtMengdeKg.Text = ValgtMalt.Malt.Mengde.ToString("0.0000", System.Globalization.CultureInfo.CurrentCulture);
            txtMengdePercent.Text = ValgtMalt.Malt.MengdeProsent.ToString("0.0000", System.Globalization.CultureInfo.CurrentCulture);
         }
      }

      private void OnLeave(object sender, EventArgs e)
      {
         TextBox tb = sender as TextBox;
         if (null != tb)
         {
            double value;
            if ((tb == txtMengdeKg) && (Classes.Util.ValidDouble(tb.Text, out value)))
            {
               double ut;
               if (Classes.Calulator.GetMaltPercentageByAmount(value, ValgtMalt.Malt.ME / 100.0, ValgtMalt.BHE, ValgtMalt.OriginalGravity, ValgtMalt.BatchVolume, out ut))
               {
                  txtMengdePercent.Text = (ut * 100.0).ToString("0.0000", System.Globalization.CultureInfo.CurrentCulture);
                  ValgtMalt.Malt.MengdeProsent = ut * 100;
                  ValgtMalt.Malt.Mengde = value;
               }
            }
            else if ((tb == txtMengdePercent) && (Classes.Util.ValidDouble(tb.Text, out value)))
            {
               double ut;
               if (Classes.Calulator.GetMaltAmountByPercentage(value / 100, ValgtMalt.Malt.ME / 100.0, ValgtMalt.BHE, ValgtMalt.OriginalGravity, ValgtMalt.BatchVolume, out ut))
               {
                  txtMengdeKg.Text = ut.ToString("0.0000", System.Globalization.CultureInfo.CurrentCulture);
                  ValgtMalt.Malt.Mengde = ut;
                  ValgtMalt.Malt.MengdeProsent = value;
               }
            }
            this.AcceptButton = btnOK;
         }
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.OK;
      }

      private void OnEnter(object sender, EventArgs e)
      {
         this.AcceptButton = null;
      }
   }

   public class ModifyHelper
   {

      public Classes.MaltType Malt { get; set; }
      public double BHE { get; set; }
      public double OriginalGravity { get; set; }
      public double BatchVolume { get; set; }

      /// <summary>
      /// Ctor
      /// </summary>
      /// <param name="malt">Aktuelt malt som skal endres</param>
      /// <param name="brew_house_efficiency">Angis som et tall mellom 0 og 1</param>
      /// <param name="original_gravity">Angis som et tall mellom 0.099 og 1.170</param>
      /// <param name="batch_volume">Antall liter ønsket sluttvolum</param>
      public ModifyHelper(Classes.MaltType malt, double brew_house_efficiency, double original_gravity, double batch_volume)
      {
         if (null != malt)
         {
            Malt = new Classes.MaltType(malt);
            BHE = brew_house_efficiency;
            OriginalGravity = original_gravity;
            BatchVolume = batch_volume;
         }
      }
   }


}
