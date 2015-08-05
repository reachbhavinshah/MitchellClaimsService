using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClaimsService.Client
{
    /// <summary>
    /// Simple UI for calling out the http services in ClaimsService. No exception handling or any other refactoring done here.
    /// </summary>
    public partial class Claims : Form
    {
        private static readonly string _ClaimServiceURL = "http://localhost:24332/";

        public Claims()
        {
            InitializeComponent();
        }

        private async void btnGetClaim_Click(object sender, EventArgs e)
        {
            string claimXml = string.Empty;
            if (String.IsNullOrEmpty(txtClaimNumber.Text))
            {
                //Show error  
            }

            claimXml = await Get(String.Format("claims/get/{0}", txtClaimNumber.Text));
            
            //Done only to indent the xml text
            XDocument xDocument = XDocument.Parse(claimXml);
            txtResult.Text = xDocument.ToString();
        }

        private async void btnGetClaims_Click(object sender, EventArgs e)
        {
            var startDate = startDatePicker.Value.ToString("yyyy-MM-dd");
            var endDate = endDatePicker.Value.ToString("yyyy-MM-dd");
            if (String.IsNullOrEmpty(startDate) || String.IsNullOrEmpty(endDate))
            {
                //Show error
            }

            var claimXml = await Get(String.Format("claims/list/{0}/{1}", startDate, endDate));
            
            //Done only to indent the xml text
            XDocument xDocument = XDocument.Parse(claimXml);
            txtResult.Text = xDocument.ToString();
        }

        private async void btnCreateClaim_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtClaimXML.Text))
            {
                //Show error
            }

            txtResult.Text = await Post("claims/create", txtClaimXML.Text);
        }

        private async Task<string> Get(string partUri)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_ClaimServiceURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync(partUri);
                return await response.Content.ReadAsStringAsync();
            }
        }

        private async Task<string> Post(string partUri, string content)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_ClaimServiceURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

                // HTTP GET
                var httpContent = new StringContent(content, Encoding.UTF8, "application/xml");
                HttpResponseMessage response = await client.PostAsync(partUri, httpContent);
                return response.IsSuccessStatusCode ? "Claim created successfully." : await response.Content.ReadAsStringAsync();
            }
        }
    }
}