using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zTempo.Helpers
{
    internal static class ZThemes
    {
        public static readonly Color COLOR_DARK_PRIMARY = ColorTranslator.FromHtml("#28626C");
        public static MaterialSkinManager ThemeMultiplicaGreen(MaterialForm materialForm)
        {
            var instance = MaterialSkinManager.Instance;
            instance.EnforceBackcolorOnAllComponents = true;
            instance.AddFormToManage(materialForm);
            instance.Theme = MaterialSkinManager.Themes.LIGHT;
            instance.ColorScheme = new ColorScheme(ColorTranslator.FromHtml("#0B4D58"), COLOR_DARK_PRIMARY, ColorTranslator.FromHtml("#699198"), ColorTranslator.FromHtml("#1BDEA6"), TextShade.WHITE);
            return instance;
        }
        public static MaterialSkinManager ThemeDarkGreen(MaterialForm materialForm)
        {
            var instance = MaterialSkinManager.Instance;
            instance.EnforceBackcolorOnAllComponents = true;
            instance.AddFormToManage(materialForm);
            instance.Theme = MaterialSkinManager.Themes.DARK;
            instance.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            return instance;
        }
    }
}
