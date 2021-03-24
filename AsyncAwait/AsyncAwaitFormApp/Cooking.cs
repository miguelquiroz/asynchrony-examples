using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakfastApp
{
    public class Cooking
    {
        #region "Attributes"
        private CheckedListBox _checkedListBox;
        private TextBox _txtLog;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="checklistBox"></param>
        /// <param name="txtLog"></param>
        public Cooking(CheckedListBox checklistBox, TextBox txtLog)
        {
            _checkedListBox = checklistBox;
            _txtLog = txtLog;
        }

        /// <summary>
        /// Make the magic
        /// </summary>
        /// <param name="product"></param>
        public virtual TimeSpan Make(Product product)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            _txtLog.AppendText($"Se empezó {product.Name}. {stopWatch.Elapsed} \r\n");
            foreach (var ingredient in product.Ingredients)
            {
                //cook ingrident
                Task.Delay(ingredient.CookingTimeMs).Wait();

                _checkedListBox.SetItemChecked(ingredient.ID, true);
                _txtLog.AppendText($"Finalizado {ingredient.Name}. {stopWatch.Elapsed} \r\n");
            }
            var elapsedTime = stopWatch.Elapsed;
            _txtLog.AppendText($"Se terminó {product.Name}. {elapsedTime} \r\n");
            stopWatch.Stop();

            return elapsedTime;
        }
    }
}
