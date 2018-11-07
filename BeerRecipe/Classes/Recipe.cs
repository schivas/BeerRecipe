using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerRecipe.Classes
{
    public class Recipe : BaseINPC2
    {
        #region Constants

        public readonly double MINIMUM_BATCH_VOLUM;
        public readonly double MAXIMUM_BATCH_VOLUM;

        public readonly double MINIMUM_FERMENTER_TRUB_LOSS;
        public readonly double MINIMUM_KETTLE_LOSS;

        public readonly double MINIMUM_SPECIFIC_GRAVITY;
        public readonly double MAXIMUM_SPECIFIC_GRAVITY;

        public readonly double MINIMUM_BOIL_TIME;
        public readonly double MAXIMUM_BOIL_TIME;

        public readonly double MINIMUM_BOIL_OF_RATE;
        public readonly double MAXIMUM_BOIL_OF_RATE;

        public readonly double MINIMUM_WATER_TO_GRAIN_RATIO;
        public readonly double MAXIMUM_WATER_TO_GRAIN_RATIO;

        public readonly double MINIMUM_WATER_LOSS_IN_GRAIN;
        public readonly double MAXIMUM_WATER_LOSS_IN_GRAIN;

        #endregion  // Constants

        #region Fields

        private Dictionary<string, MaltType> _Malts;



        #endregion  // Fields

        #region Construction

        public Recipe()
        {
            //_counter = 1;
            MINIMUM_BATCH_VOLUM = 0;
            MAXIMUM_BATCH_VOLUM = 10000;

            MINIMUM_FERMENTER_TRUB_LOSS = 0;
            MINIMUM_KETTLE_LOSS = 0;

            // Leste av disse verdiene på en Oechslevekt/hydrometer, bør holde plenty
            MINIMUM_SPECIFIC_GRAVITY = 0.990;
            MAXIMUM_SPECIFIC_GRAVITY = 1.170;

            MINIMUM_BOIL_TIME = 30;
            MAXIMUM_BOIL_TIME = 320;

            MINIMUM_BOIL_OF_RATE = 0;
            MAXIMUM_BOIL_OF_RATE = 10;

            MINIMUM_WATER_TO_GRAIN_RATIO = 2;
            MAXIMUM_WATER_TO_GRAIN_RATIO = 8;

            MINIMUM_WATER_LOSS_IN_GRAIN = 0;
            MAXIMUM_WATER_LOSS_IN_GRAIN = 2;

            _Malts = new Dictionary<string, MaltType>();
            //BatchVolum = 25;
            //FermenterTrubLoss = 2;
            //KettleLoss = 3.5;
            //OriginalGravity = 1.040;
            //BoilTime = 60;
            //BoilOfRate = 2.5;
            //BHE = 75;
            //WaterLossInGrain = 0.8;
            //WGR = 3;
        }

        #endregion  // Construction

        public bool ForceUpdate { get; set; }

        public bool AddMalt(MaltType malt)
        {
            bool ret = false;
            try
            {
                if ((malt != null) && (_Malts != null) && !_Malts.ContainsKey(malt.Malttype.ToLower()))
                {
                    _Malts.Add(malt.Malttype.ToLower(), new MaltType(malt));
                    ret = _Malts.ContainsKey(malt.Malttype.ToLower());
                }
            }
            catch { ret = false; }
            return ret;
        }

        public Dictionary<string, MaltType> GetMalts()
        {
            Dictionary<string, MaltType> ret = new Dictionary<string, MaltType>();

            try
            {
                if ((_Malts != null) && (_Malts.Count > 0))
                {
                    foreach (var item in _Malts)
                    {
                        ret.Add(item.Key, new MaltType(item.Value));
                    }
                }
            }
            catch { ret = new Dictionary<string, MaltType>(); }
            return ret;
        }

        public bool GetMalt(string key, out MaltType malt)
        {
            malt = null;
            try
            {
                if (ContainsMalt(key))
                {
                    malt = new MaltType(_Malts[key]);
                }
            }
            catch { }
            return (null != malt);
        }

        public bool RemoveMalt(MaltType malt)
        {
            bool ret = false;
            try
            {
                if ((malt != null) && ContainsMalt(malt))
                {
                    ret = _Malts.Remove(malt.Malttype.ToLower());
                }
            }
            catch { }
            return ret;
        }

        public bool RemoveMalt(string key)
        {
            bool ret = false;
            try
            {
                if ((_Malts != null) && _Malts.ContainsKey(key))
                {
                    ret = _Malts.Remove(key);
                }
            }
            catch { }
            return ret;
        }

        public bool ReplaceMalt(MaltType malt)
        {
            bool ret = false;
            try
            {
                if ((malt != null) && ContainsMalt(malt))
                {
                    _Malts[malt.Malttype.ToLower()] = new MaltType(malt);
                }
            }
            catch { }
            return ret;
        }

        public void ClearMalts()
        {
            if (_Malts != null)
            {
                _Malts.Clear();
            }
        }

        public bool ContainsMalt()
        {
            return ((_Malts != null) && (_Malts.Count > 0));
        }

        public bool ContainsMalt(MaltType malt)
        {
            return ((malt != null) && (_Malts != null) && _Malts.ContainsKey(malt.Malttype.ToLower()));
        }

        public bool ContainsMalt(string key)
        {
            return ((_Malts != null) && _Malts.ContainsKey(key));
        }





        #region Not dependent properties

        double _BatchVolum;
        double _FermenterTrubLoss;
        double _KettleLoss;
        double _OriginalGravity;
        double _BoilTime;
        double _BoilOfRate;
        double _BHE;
        double _WaterLossInGrain;
        double _WGR;
        bool _AdjustForVolTempChangeInWater;

        public bool AdjustForVolTempChangeInWater
        {
            get { return _AdjustForVolTempChangeInWater; }
            set
            {
                if (_AdjustForVolTempChangeInWater != value)
                {
                    _AdjustForVolTempChangeInWater = value;
                    this.RaisePropertyChanged("AdjustForVolTempChangeInWater");
                }
            }
        }

        /// <summary>
        /// Batch volum in liter (after boil) - ønsket sluttvolum
        /// The batch size is easily put how much beer this recipe will make.
        /// However batch size means different things for different people. This application will use this definition:
        /// Into bottles/kegs - This means how much beer you end up with in the end after all losses are accounted for. This is the default value for new users.
        /// </summary>
        public double BatchVolum
        {
            get { return _BatchVolum; }
            set
            {
                double newVal = (value < MINIMUM_BATCH_VOLUM) ? MINIMUM_BATCH_VOLUM : ((value > MAXIMUM_BATCH_VOLUM) ? MAXIMUM_BATCH_VOLUM : value);
                if (newVal != _BatchVolum)
                {
                    _BatchVolum = newVal;
                    //this.RaisePropertyChanged("BatchVolum");
                    this.RaisePropertyChanged();
                    if (ContainsMalt() || ForceUpdate)
                    {
                        //this.RaiseKeyPropertyChanged("BatchVolum");
                        this.RaiseKeyPropertyChanged();
                    }
                }
            }
        }

        /// <summary>
        /// Fermenter trub loss, tap grunnet gjær, humle etc. som blir liggende igjen i gjæringskar etter at ølet er tappet på flasker/fat
        /// The fermenter trub loss is the amount of liquid and trub remaining in the fermenter after transferring to either secondary, bottles or kegs.
        /// If transferring to a secondary, any trub loss in the secondary should also be added to the primary fermenter trub loss.
        /// The trub loss will vary both due to your equipment, and also the amount of hops used, the yeast and if you dry hopped or not.
        /// </summary>
        public double FermenterTrubLoss
        {
            get { return _FermenterTrubLoss; }
            set
            {
                double newVal = (value < MINIMUM_FERMENTER_TRUB_LOSS) ? MINIMUM_FERMENTER_TRUB_LOSS : ((value > BatchVolum) ? BatchVolum : value);
                if (newVal != _FermenterTrubLoss)
                {
                    _FermenterTrubLoss = newVal;
                    this.RaisePropertyChanged("FermenterTrubLoss");
                    if (ContainsMalt() || ForceUpdate)
                    {
                        this.RaiseKeyPropertyChanged("FermenterTrubLoss");
                    }
                }
            }
        }

        //
        /// <summary>
        /// The total volume of liquid left in the boiling kettle after transfer to the fermentor.
        /// This depends on the deadspace in the boiling kettle, and also the amount of trub that will vary depending on the hop amount used.
        /// </summary>
        public double KettleLoss
        {
            get { return _KettleLoss; }
            set
            {
                double newVal = (value < MINIMUM_KETTLE_LOSS) ? MINIMUM_KETTLE_LOSS : ((value > BatchVolum) ? BatchVolum : value);
                if (newVal != _KettleLoss)
                {
                    _KettleLoss = newVal;
                    this.RaisePropertyChanged("KettleLoss");
                    if (ContainsMalt() || ForceUpdate)
                    {
                        this.RaiseKeyPropertyChanged("KettleLoss");
                    }
                }
            }
        }

        /// <summary>
        /// Original Gravity
        /// </summary>
        public double OriginalGravity
        {
            get { return _OriginalGravity; }
            set
            {
                double newVal = (value < MINIMUM_SPECIFIC_GRAVITY) ? MINIMUM_SPECIFIC_GRAVITY : ((value > MAXIMUM_SPECIFIC_GRAVITY) ? MAXIMUM_SPECIFIC_GRAVITY : value);
                if (newVal != _OriginalGravity)
                {
                    _OriginalGravity = newVal;
                    this.RaisePropertyChanged("OriginalGravity");
                    if (ContainsMalt() || ForceUpdate)
                    {
                        this.RaiseKeyPropertyChanged("OriginalGravity");
                    }
                }
            }
        }

        /// <summary>
        /// How long to boil the batch (in minutes) - Koketid
        /// </summary>
        public double BoilTime
        {
            get { return _BoilTime; }
            set { _BoilTime = (value < MINIMUM_BOIL_TIME) ? MINIMUM_BOIL_TIME : ((value > MAXIMUM_BOIL_TIME) ? MAXIMUM_BOIL_TIME : value); this.RaisePropertyChanged("BoilTime"); }
        }

        /// <summary>
        /// How much you should expect to lose of the batch, in liters, per hour it's boiling - Avdampning
        /// </summary>
        public double BoilOfRate
        {
            get { return _BoilOfRate; }
            set { _BoilOfRate = (value < MINIMUM_BOIL_OF_RATE) ? MINIMUM_BOIL_OF_RATE : ((value > MAXIMUM_BOIL_OF_RATE) ? MAXIMUM_BOIL_OF_RATE : value); this.RaisePropertyChanged("BoilOfRate"); }
        }

        /// <summary>
        /// Brewhouse Efficiency / Bryggehuseffektivitet (%)
        /// </summary>_BHE;
        public double BHE
        {
            get { return _BHE; }
            set
            {
                double newVal = (value < 0) ? 0 : ((value > 100) ? 100 : value);
                if (newVal != _BHE)
                {
                    _BHE = newVal;
                    this.RaisePropertyChanged("BHE");
                    if (ContainsMalt() || ForceUpdate)
                    {
                        this.RaiseKeyPropertyChanged("BHE");
                    }
                }
            }
        }

        /// <summary>
        /// When mashing, some of the water will be lost/stuck in the grains - Mesketap
        /// </summary>
        public double WaterLossInGrain
        {
            get { return _WaterLossInGrain; }
            set { _WaterLossInGrain = (value < MINIMUM_WATER_LOSS_IN_GRAIN) ? MINIMUM_WATER_LOSS_IN_GRAIN : ((value > MAXIMUM_WATER_LOSS_IN_GRAIN) ? MAXIMUM_WATER_LOSS_IN_GRAIN : value); this.RaisePropertyChanged("WaterLossInGrain"); }
        }

        /// <summary>
        /// Water to Grain Ratio - Vann/malt forhold
        /// </summary>
        public double WGR
        {
            get { return _WGR; }
            set { _WGR = (value < MINIMUM_WATER_TO_GRAIN_RATIO) ? MINIMUM_WATER_TO_GRAIN_RATIO : ((value > MAXIMUM_WATER_TO_GRAIN_RATIO) ? MAXIMUM_WATER_TO_GRAIN_RATIO : value); this.RaisePropertyChanged("WGR"); }
        }

        #endregion  // Not dependent properties

        /// <summary>
        /// The amount of grain/malt - maltmengde
        /// </summary>
        public double MaltAmount { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        public void CalculateAmount()
        {
            try
            {
                double ret = 0;
                foreach (var item in _Malts)
                {
                    if (!double.IsNaN(item.Value.Mengde) && !double.IsInfinity(item.Value.Mengde))
                    {
                        ret += item.Value.Mengde;
                    }
                }
                MaltAmount = ret;
            }
            catch { }
        }

        /// <summary>
        /// Batch volum in liter (pre boil) - Kokevolum
        /// </summary>
        public double BoilVolum
        {
            get
            {
                double ret = 0;
                try
                {
                    ret = (BatchVolum + FermenterTrubLoss + KettleLoss) * (AdjustForVolTempChangeInWater ? 1.04 : 1.0); // Take into account 4% volume reduction when then water temperaturen is decreased from boiling to 20 °C
                    ret += ((BoilTime / 60) * BoilOfRate); // Add the boil off
                    if (double.IsNaN(ret) || double.IsInfinity(ret))
                    {
                        ret = 0;
                    }
                }
                catch { ret = 0; }
                return ret;
            }
        }

        /// <summary>
        /// Gravity Points (TP - Tetthetspoeng)
        /// </summary>
        public double TP { get { return (OriginalGravity - 1) * BatchVolum * 1000; } }

        /// <summary>
        /// Once the barley has been malted or other grains crushed, water is added to begin the formation of the mash. This water is called strike water - Meskevolum
        /// </summary>
        public double StrikeVolum
        {
            get
            {
                double ret = 0;
                try
                {
                    ret = this.MaltAmount * this.WGR;
                    if (double.IsNaN(ret) || double.IsInfinity(ret))
                    {
                        ret = 0;
                    }
                }
                catch { ret = 0; }
                return ret;
            }
        }

        /// <summary>
        /// Skyllevann, eller på engelsk - sparge water, brukes til å skylle ut sukkerrester fra malten er ferdig mesking.
        /// </summary>
        public double SpargeVolum
        {
            get
            {
                double ret = 0;
                try
                {
                    ret = (this.BoilVolum - (this.WGR * this.MaltAmount)) + (this.MaltAmount * this.WaterLossInGrain);
                    if (double.IsNaN(ret) || double.IsInfinity(ret))
                    {
                        ret = 0;
                    }
                }
                catch { ret = 0; }
                return ret;
            }
        }

        /// <summary>
        /// The specific gravity on the wort when the meshing is finished, but before the wort starts to boil.
        /// This is nice to know in order to adjust the gravity on the wort to hit the OG given in the recipe.
        /// Source: https://forum.norbrygg.no/threads/sg-for-kok.18884/
        /// </summary>
        public double SpecificGravity
        {
            get
            {
                double ret = 1;
                try
                {
                    //ret = 1 + (((OriginalGravity - 1.0) * BatchVolum) / BoilVolum);
                    //if (this.AdjustForVolTempChangeInWater)
                    //{
                    //    ret = 1 + (((OriginalGravity - 1.0) * (BatchVolum + this.FermenterTrubLoss)) / ((BoilVolum / 100) * 96)); // assume OriginalGravity is given for BatchVolum at 20°C, and also assume that BoilVolum is given immediatly before boliling (i.e. assume 100°C), convert the volume to volume at 20°C.
                    //}
                    //else
                    //{
                    //    ret = 1 + (((OriginalGravity - 1.0) * (BatchVolum + this.FermenterTrubLoss)) / BoilVolum);
                    //}
                    double total_evaporation =  BoilOfRate * (BoilTime / 60);
                    double post_boil = this.BoilVolum - total_evaporation;
                    double after_volume = post_boil - this.KettleLoss;
                    ret = 1 + (((OriginalGravity - 1.0) * after_volume) / BoilVolum);
                }
                catch { ret = 1; }
                return ret;
            }
        }
    }
}
