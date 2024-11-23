using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_EgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            
            lblLocationCount.Text=db.TblLocation.Count().ToString();
            lblSumCapasity.Text=db.TblLocation.Sum(x=>x.LocationCapacity ).ToString();
            lblGuideCount.Text=db.TblGuide.Count().ToString();
            lblAvgCapasity.Text=db.TblLocation.Average(x=>x.LocationCapacity ).ToString();
            lblAvgLocationPrice.Text=db.TblLocation.Average(x=>x.LocationPrice ).ToString();

            int LastCountryId = db.TblLocation.Max(x => x.LocationId);
            lblLastCountryName.Text = db.TblLocation.Where(x => x.LocationId == LastCountryId).Select(y => y.LocationCountry).FirstOrDefault();


            lblCapadociaLocationCapasity.Text = db.TblLocation.Where(x => x.LocationCity == "Kapadokya").Select(y => y.LocationCapacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text=db.TblLocation.Where(x=>x.LocationCountry=="Türkiye").Average(y=>y.LocationCapacity).ToString();

            var romeGuideId = db.TblLocation.Where(x => x.LocationCity == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text=db.TblGuide.Where(x=>x.GuideId == romeGuideId).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString() ;


            var maxCapacity=db.TblLocation.Max(x=>x.LocationCapacity);
            lblMAxCapacityLocation.Text = db.TblLocation.Where(x => x.LocationCapacity == maxCapacity).Select(y => y.LocationCity).FirstOrDefault().ToString();


            var maxPrice=db.TblLocation.Max(x=>x.LocationPrice);
            lblMaxPriceLocation.Text = db.TblLocation.Where(x => x.LocationPrice == maxPrice).Select(y => y.LocationCity).FirstOrDefault().ToString();


            var guideIdByNameAysegulCınar = db.TblGuide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCınarLocation.Text = db.TblLocation.Where(x => x.GuideId == guideIdByNameAysegulCınar).Count().ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxPriceLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
