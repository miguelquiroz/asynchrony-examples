using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakfastApp
{
    /// <summary>
    /// main form class
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// Directory
        /// </summary>
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        private Cooking _cooking;

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();           
            _cooking = new Cooking(cblbbreakfast, txtLog);
        }

        /// <summary>
        /// Show items in checklist
        /// </summary>
        /// <param name="product"></param>
        protected void buildComboBoxItems(Product product)
        {
            cblbbreakfast.Items.Clear();

            foreach (var ingredient in product.Ingredients)
            {
                cblbbreakfast.Items.Add($"{ingredient.Name} is ready");
            }
        }

        /// <summary>
        /// Do task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSyncTest_A_Click(object sender, EventArgs e)
        {
            //make instance of product
            var product = new Product("Breakfast");

            //adding ingredients to the selected product
            product.AddIngredient("Coffee", 5000);
            product.AddIngredient("Eggs", 2000);
            product.AddIngredient("Bacon", 500);
            product.AddIngredient("Toast", 500);
            product.AddIngredient("Hot cakes", 2000);

            //build comboBox to show ingredients / steps
            buildComboBoxItems(product);

            //cooking the product
            var elapsedTime = _cooking.Make(product);

            //grade
            if (elapsedTime.TotalSeconds >= 9)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(AssemblyDirectory, "img\\sad_cocinero.jpg"));
            }
            else
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(AssemblyDirectory, "img\\perfect_cocinero.jpg"));
            }

            //log
            txtLog.AppendText($"\r\n {product.Name} is ready !!! :)");
            txtLog.AppendText($"\r\n ------------------------------ \r\n");
        }
    }
}
