using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using GemBox.Spreadsheet;
using System.ComponentModel;

using OfficeOpenXml;
using System.IO;

namespace BeerRecipe.Classes
{

    public class MaltType
    {
        public static readonly int EXCEL_ROW_COUNT = 13;

        public MaltType()
        {
            Malttype = Kategori = Malteri = Type = Kornsort = Enzymaktivitet = Fargebidrag = AnbefaltMengde = Smaksbidrag = Bruksområde = Kommentar = RowDefinition = "";
            MEa = MEb = double.NaN;
            ParsedOk = false;
        }

        public MaltType(string row_definition)
           : this()
        {
            RowDefinition = row_definition;
            ParsedOk = Parse(row_definition);
        }
        public MaltType(MaltType other)
           : this()
        {
            if (other != null)
            {
                this.AnbefaltMengde = other.AnbefaltMengde;
                this.Bruksområde = other.Bruksområde;
                this.Enzymaktivitet = other.Enzymaktivitet;
                this.Fargebidrag = other.Fargebidrag;
                this.Kategori = other.Kategori;
                this.Kommentar = other.Kommentar;
                this.Kornsort = other.Kornsort;
                this.Malteri = other.Malteri;
                this.Malttype = other.Malttype;
                this.MEa = other.MEa;
                this.MEb = other.MEb;
                this.Mengde = other.Mengde;
                this.MengdeProsent = other.MengdeProsent;
                this.ParsedOk = other.ParsedOk;
                this.RowDefinition = other.RowDefinition;
                this.Smaksbidrag = other.Smaksbidrag;
                this.Type = other.Type;
            }
        }

        public bool ParsedOk { get; set; }

        public string Malttype { get; set; }
        public string Kategori { get; set; }
        public string Malteri { get; set; }
        public string Type { get; set; }
        public string Kornsort { get; set; }
        public double MEa { get; set; }
        public double MEb { get; set; }

        /// <summary>
        /// We prefer MEa. This property will return MEa if it is defined, else it will return MEb converted to MEa, if MEb is defined.
        /// </summary>
        public double ME { get { return double.IsNaN(MEa) ? (double.IsNaN(MEb) ? MEb : ((MEb / 384) * 100)) : MEa; } }

        public string Enzymaktivitet { get; set; }
        public string Fargebidrag { get; set; }
        public string AnbefaltMengde { get; set; }
        public string Smaksbidrag { get; set; }
        public string Bruksområde { get; set; }
        public string Kommentar { get; set; }

        public string RowDefinition { get; set; }

        /// <summary>
        /// Kun brukt når en skal beregne maltmengde (i kg). Da angir en aktuell maltmengde i % her (0 - 1)
        /// </summary>
        public double MengdeProsent { get; set; }

        public double Mengde { get; set; }

        public bool Parse(string row_definition)
        {
            if (string.IsNullOrEmpty(row_definition))
            {
                return false;
            }
            bool ret = false;
            try
            {
                string[] cells = row_definition.Split(new char[] { '|' });
                if (cells.Length == EXCEL_ROW_COUNT)
                {

                    int i = 0;
                    Malttype = cells[i++];
                    Kategori = cells[i++];
                    Malteri = cells[i++];
                    Type = cells[i++];
                    Kornsort = cells[i++];

                    double d = 0;

               //if (double.TryParse(cells[i++].Replace(",", "."), out d))
               if (Util.ValidDouble(cells[i++], out d))
               {
                        MEa = d;
                    }
               //if (double.TryParse(cells[i++].Replace(",", "."), out d))
               if (Util.ValidDouble(cells[i++], out d))
               {
                        MEb = d;
                    }
                    Enzymaktivitet = cells[i++];
                    Fargebidrag = cells[i++];
                    AnbefaltMengde = cells[i++];
                    Smaksbidrag = cells[i++];
                    Bruksområde = cells[i++];
                    Kommentar = cells[i++];

                    if (!string.IsNullOrEmpty(Malteri))
                    {
                        string t = Malteri.ToUpper();
                        switch (t)
                        {
                            case "CM":
                                Malteri = "Castle Malting";
                                break;
                            case "TF":
                                Malteri = "Thomas Fawcett";
                                break;
                            case "WM":
                                Malteri = "Weyermann";
                                break;
                            case "WMB":
                                Malteri = "Weyermann Barke";
                                break;
                            default:
                                break;
                        }
                    }
                    ret = true;
                }
            }
            catch { }
            return ret;
        }

        public double GetMEa_For_MEb(double MEb)
        {
            double ret = double.NaN;
            if (MEa != double.NaN)
            {
                ret = MEa / 384.0;
            }
            return ret;
        }

        public double GetMEb_For_MEa(double MEa)
        {
            double ret = double.NaN;
            if (this.MEa != double.NaN)
            {
                ret = this.MEa * 384.0;
            }
            return ret;
        }

        public override string ToString()
        {
            string s = "";
            s += "Malttype: " + (Malttype ?? "");
            s += ", Mengde: " + Mengde.ToString() + " [" + Mengde.GetHashCode().ToString() + "]";
            s += ", MengdeProsent: " + MengdeProsent.ToString() + " [" + MengdeProsent.GetHashCode().ToString() + "]";
            s += ", ParsedOk: " + ParsedOk.ToString();
            s += ", Kategori: " + (Kategori ?? "");
            s += ", Malteri: " + (Malteri ?? "");
            s += ", Type: " + (Type ?? "");
            s += ", Kornsort: " + (Kornsort ?? "");
            s += ", MEa: " + MEa.ToString() + " [" + MEa.GetHashCode().ToString() + "]";
            s += ", MEb: " + MEb.ToString() + " [" + MEb.GetHashCode().ToString() + "]";
            s += ", Enzymaktivitet: " + (Enzymaktivitet ?? "");
            s += ", Fargebidrag: " + (Fargebidrag ?? "");
            s += ", AnbefaltMengde: " + (AnbefaltMengde ?? "");
            s += ", Smaksbidrag: " + (Smaksbidrag ?? "");
            s += ", Bruksområde: " + (Bruksområde ?? "");
            s += ", Kommentar: " + (Kommentar ?? "");
            s += ", RowDefinition: " + (RowDefinition ?? "");
            return s;
        }

        public override bool Equals(object obj)
        {
            MaltType other = obj as MaltType;
            if (null != other)
            {
                return this.ToString().Equals(other.ToString());
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }

    //public class MaltMengde
    //{
    //   public MaltType Malt { get; set; }
    //   public double BHE { get; set; }
    //   public double OG { get; set; }
    //   public double BatchSize { get; set; }
    //}

    public static class Util
    {
      /*
        public static Dictionary<string, Dictionary<string, Classes.MaltType>> LoadMalts(string file, out string error)
        {
            error = "";
            Dictionary<string, Dictionary<string, Classes.MaltType>> ret = new Dictionary<string, Dictionary<string, MaltType>>();
            try
            {
                SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                ExcelFile ef = ExcelFile.Load(file);

                //StringBuilder sb = new StringBuilder();
                //int colcnt = 11;

                foreach (GemBox.Spreadsheet.ExcelWorksheet sheet in ef.Worksheets)
                {
                    //string fane = sheet.Name;
                    ret.Add(sheet.Name, new Dictionary<string, Classes.MaltType>());
                    int r_index = 0;
                    bool firstRow = true;
                    foreach (GemBox.Spreadsheet.ExcelRow row in sheet.Rows)
                    {
                        r_index++;
                        if (firstRow)
                        {
                            firstRow = false;
                            continue;
                        }
                        string line = "";
                        for (int c_index = 0; c_index < MaltType.EXCEL_ROW_COUNT; c_index++)
                        {
                            ExcelCell cell = row.Cells[0, c_index];
                            if (cell.Value != null)
                            {
                                line += cell.Value.ToString();
                            }
                            if (c_index < MaltType.EXCEL_ROW_COUNT - 1)
                            {
                                line += "|";
                            }
                        }

                        Classes.MaltType mt = new Classes.MaltType(line);
                        if (mt.ParsedOk)
                        {
                            if (!ret[sheet.Name].ContainsKey(mt.Malttype.ToLower()))
                            {
                                ret[sheet.Name].Add(mt.Malttype.ToLower(), mt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return ret;
        }
      */

        public static Dictionary<string, Dictionary<string, Classes.MaltType>> LoadMalts_EEPLUS(string file, out string error)
        {
            error = "";

            Dictionary<string, Dictionary<string, Classes.MaltType>> ret = new Dictionary<string, Dictionary<string, MaltType>>();
            try
            {

                //SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                //ExcelFile ef = ExcelFile.Load(file);

                FileInfo newFile = new FileInfo(file);
                ExcelPackage pck = new ExcelPackage(newFile);

                foreach (var sheet in pck.Workbook.Worksheets)
                {
                    ret.Add(sheet.Name, new Dictionary<string, Classes.MaltType>());
                    int r_index = 0;
                    bool firstRow = true;
                    //bool done_rows = false;
                    //int i = 0;
                    //while (done_rows)
                    //{
                    //    string tt = sheet.Cells[i, 0].ToString();
                    //    i++;
                    //}

                    for (int row = sheet.Dimension.Start.Row; row <= sheet.Dimension.End.Row; row++)
                    {
                        if (row == sheet.Dimension.Start.Row)
                        {
                            continue; // skip header
                        }
                        string line = "";
                        int columns_end = (sheet.Dimension.End.Column <= MaltType.EXCEL_ROW_COUNT) ? sheet.Dimension.End.Column : MaltType.EXCEL_ROW_COUNT;
                        for (int c_index = sheet.Dimension.Start.Column; c_index <= columns_end; c_index++)
                        {
                            OfficeOpenXml.ExcelRow e_row = sheet.Row(row);
                            ExcelRange cell = sheet.Cells[row, c_index];
                            if (cell.Value != null)
                            {
                                line += cell.Value.ToString();
                            }
                            if (c_index < MaltType.EXCEL_ROW_COUNT)
                            {
                                line += "|";
                            }
                        }
                        Classes.MaltType mt = new Classes.MaltType(line);
                        if (mt.ParsedOk)
                        {
                            if (!ret[sheet.Name].ContainsKey(mt.Malttype.ToLower()))
                            {
                                ret[sheet.Name].Add(mt.Malttype.ToLower(), mt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return ret;
        }

        public static bool ValidDouble(string value_as_text, out double val)
        {
            val = 0;
            bool ret = false;
            if (!string.IsNullOrEmpty(value_as_text))
            {
                value_as_text = value_as_text.Replace(',', '.');
                if (double.TryParse(value_as_text, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out val))
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool ValidDouble(string value_as_text)
        {
            double val;
            return ValidDouble(value_as_text, out val);
        }
    }



    internal static class Calulator
    {
        public static bool GetMaltAmountByPercentage(double percentage_amount, double percentage_efficiency, double bhe, double target_OG, double batch_volum, out double malt_amount)
        {
            malt_amount = 0;

            if ((percentage_amount < 0) /*|| (percentage_amount > 1)*/)
            {
                return false;
            }
            if ((percentage_efficiency < 0) || (percentage_efficiency > 1))
            {
                return false;
            }
            if ((bhe < 0) || (bhe > 1))
            {
                return false;
            }
            if ((target_OG < 0.990) || (target_OG > 1.170))
            {
                return false;
            }

            double tp = (target_OG - 1.0) * 1000.0 * batch_volum; // Ligning 2
            double teller = tp * percentage_amount;
            double nevner = percentage_efficiency * 384.0 * bhe;
            malt_amount = teller / nevner; // Ligning 7
            return !double.IsNaN(malt_amount) && !double.IsInfinity(malt_amount);
        }

        public static bool GetMaltPercentageByAmount(double malt_amount, double percentage_efficiency, double bhe, double target_OG, double batch_volum, out double percentage_amount)
        {
            percentage_amount = 0;

            if (malt_amount < 0)
            {
                return false;
            }
            if ((percentage_efficiency < 0) || (percentage_efficiency > 1))
            {
                return false;
            }
            if ((bhe < 0) || (bhe > 1))
            {
                return false;
            }
            if ((target_OG < 0.990) || (target_OG > 1.170))
            {
                return false;
            }

            double tp = (target_OG - 1.0) * 1000.0 * batch_volum; // Ligning 2
            percentage_amount = (malt_amount * percentage_efficiency * 384.0 * bhe) / tp; // Ligning 7 - løst mht. percentage_amount
            return !double.IsNaN(percentage_amount) && !double.IsInfinity(percentage_amount);
        }

        public static bool GetOriginalGravity(double malt_amount, double percentage_amount, double percentage_efficiency, double bhe, double batch_volum, out double target_OG)
        {
            target_OG = 0;
            if (malt_amount < 0)
            {
                return false;
            }
            if ((percentage_amount < 0) || (percentage_amount > 1))
            {
                return false;
            }
            if ((percentage_efficiency < 0) || (percentage_efficiency > 1))
            {
                return false;
            }
            if ((bhe < 0) || (bhe > 1))
            {
                return false;
            }
            target_OG = 1.0 + ((malt_amount * percentage_efficiency * 384.0 * bhe) / (percentage_amount * 1000.0 * batch_volum));
            return !double.IsNaN(target_OG) && !double.IsInfinity(target_OG);
        }

        public static double GetPointsPoundGallon_PGG(double MEa)
        {
            // To calculate the maximum yield for the malts and other adjuncts, the percent extraction for each is multiplied by the reference number for sucrose-46 points/pound/gallon (ppg).
            // Source: http://howtobrew.com/book/section-2/what-is-malted-grain/extraction-and-maximum-yield
            MEa = (MEa > 1) ? (MEa / 100.0) : MEa; // If larger than 1, assume percentage is in [0, 100], else assume in [0, 1]
            return (46.0 * MEa);
        }

        public static double GetPotential(double MEa)
        {
            MEa = (MEa > 1) ? (MEa / 100.0) : MEa; // If larger than 1, assume percentage is in [0, 100], else assume in [0, 1]
            return 1.0 + ((46.0 * MEa) / 1000);
        }

        public static double GetPlato(double MEa)
        {
            // I've seen this calculated by PPG / 4.
            // Alternativ metode, basert på uttalelse i "Brygg mer", side 36, om at SG = 1.00384 er tilnærmet likt 1°P
            return (GetPotential(MEa) - 1.0) / 0.00384;
        }

        //=(-1 * 616.868) + (1111.14 * sg) - (630.272 * Math.Pow(sg, 2)) + (135.997 * Math.Pow(sg, 3))

        public static double GetPlatoAdvanced(double MEa)
        {
            double sg = GetPotential(MEa);
            // Source: http://www.brewersfriend.com/plato-to-sg-conversion-chart/
            return (-1 * 616.868) + (1111.14 * sg) - (630.272 * Math.Pow(sg, 2)) + (135.997 * Math.Pow(sg, 3));
        }
    }


}
