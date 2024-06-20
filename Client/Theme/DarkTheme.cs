using MudBlazor;

namespace ThemePOC.Client.Theme
{
    public class DarkTheme : MudTheme
    {
       
        public DarkTheme()
        {
            Palette = new Palette()
            {
                Primary = Colors.Blue.Darken1,
                Info = "#5BC2AD",
                Error = "#ED1966",
                Warning = "#FBA919",
                Success = "#6DBE45",
                Secondary = "#ea80fc",
                Tertiary = Colors.LightBlue.Default,
                AppbarBackground = Colors.Shades.Black,
                //AppbarText = Colors.Grey.Default,
                Background = "#32333DFF",
                //Surface = Colors.Grey.Darken4,
                DrawerBackground = Colors.Grey.Darken4,
                //DrawerText = Colors.Grey.Default,
                //TextPrimary = Colors.Shades.White,
                DarkContrastText = Colors.Grey.Default,
                //BackgroundGrey = Colors.Grey.Lighten4,
                PrimaryContrastText = Colors.Shades.White,
                InfoContrastText = Colors.Shades.White,
                SecondaryContrastText = Colors.Shades.White,
                TertiaryContrastText = Colors.Shades.White,
                SuccessContrastText = Colors.Shades.White,
                ErrorContrastText = Colors.Shades.White,
                WarningContrastText = Colors.Shades.White,
                Black = "rgba(39, 39, 47, 1)",
                Dark = "rgba(39, 39, 47, 1)",
                //Background = "rgba(50, 51, 61, 1)",
                BackgroundGrey = "rgba(39, 39, 47, 1)",
                Surface = "rgba(55, 55, 64, 1)",
                DrawerIcon = "rgba(255, 255, 255, 0.4)",
                LinesDefault = "rgba(255, 255, 255, 0.1)",
                LinesInputs = "rgba(255, 255, 255, 0.2)",
                TableLines = "rgba(255, 255, 255, 0.1)",
                TableStriped = "rgba(255, 255, 255, 0.2)",
                Divider = "rgba(255, 255, 255, 0.1)",
                DividerLight = "rgba(255, 255, 255, 0.0)",
                ChipDefault = "rgba(255, 255, 255, 0.1)",
                ChipDefaultHover= "rgba(255, 255, 255, 0.2)",
                DarkDarken = "rgb(23,23,28)",
                DarkLighten = "rgb(56,56,67)",
                ActionDefault = "rgba(173, 173, 177, 1)",
                ActionDisabled = "rgba(255, 255, 255, 0.2)",
                ActionDisabledBackground = "rgba(255, 255, 255, 0.1)",
                TextDisabled = "rgba(255, 255, 255, 0.2)",
                TextPrimary = "rgba(255, 255, 255, 0.6)",
                TextSecondary = "rgba(255, 255, 255, 0.4)",
                DrawerText = "rgba(255, 255, 255, 0.4)",
                AppbarText = "rgba(255, 255, 255, 0.6)",


            };
           


            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = ".875rem",
                    FontWeight = 400,
                    LineHeight = 1.43,
                    LetterSpacing = ".01071em"
                },
                H1 = new H1()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "6rem",
                    FontWeight = 300,
                    LineHeight = 1.167,
                    LetterSpacing = "-.01562em"
                },
                H2 = new H2()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "3.75rem",
                    FontWeight = 300,
                    LineHeight = 1.2,
                    LetterSpacing = "-.00833em"
                },
                H3 = new H3()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "3rem",
                    FontWeight = 400,
                    LineHeight = 1.167,
                    LetterSpacing = "0"
                },
                H4 = new H4()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "2.125rem",
                    FontWeight = 400,
                    LineHeight = 1.235,
                    LetterSpacing = ".00735em"
                },
                H5 = new H5()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "1.5rem",
                    FontWeight = 400,
                    LineHeight = 1.334,
                    LetterSpacing = "0"
                },
                H6 = new H6()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "1.25rem",
                    FontWeight = 400,
                    LineHeight = 1.6,
                    LetterSpacing = ".0075em"
                },
                Button = new Button()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = ".875rem",
                    FontWeight = 500,
                    LineHeight = 1.75,
                    LetterSpacing = ".02857em"
                },
                Body1 = new Body1()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "1rem",
                    FontWeight = 400,
                    LineHeight = 1.5,
                    LetterSpacing = ".00938em"
                },
                Body2 = new Body2()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = ".875rem",
                    FontWeight = 400,
                    LineHeight = 1.43,
                    LetterSpacing = ".01071em"
                },
                Caption = new Caption()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = ".75rem",
                    FontWeight = 400,
                    LineHeight = 1.66,
                    LetterSpacing = ".03333em"
                },
                Subtitle2 = new Subtitle2()
                {
                    FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                    FontSize = ".875rem",
                    FontWeight = 500,
                    LineHeight = 1.57,
                    LetterSpacing = ".00714em"
                }
            };
            Shadows = new Shadow();
            ZIndex = new ZIndex();
        }
    }
}
