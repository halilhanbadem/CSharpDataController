using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latemERPAmateurProgrammilityOpenSource.Layers.OtherClass
{
    public class AllMessages
    {
        public void HataMesaji(string content)
        {
            MessageBox.Show(content, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void BilgiMesaji(string content)
        {
            MessageBox.Show(content, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UyariMesaji(string content)
        {
            MessageBox.Show(content, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public bool SoruMesaji(string content)
        {
            DialogResult mesaj = MessageBox.Show(content, "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mesaj == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
