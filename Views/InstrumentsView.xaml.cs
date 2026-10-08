using TomInstList.Models;

namespace TomInstList.Views;

public partial class InstrumentsView : ContentPage
{
    public List<Instruments> InstrumentList { get; set; }

    public InstrumentsView()
    {
        InitializeComponent();

        InstrumentList = new List<Instruments>
        {
            new Instruments
            {
                Name = "Bass Guitar",
                Type = "String Instrument",
                Image = "bass.png"
            },

            new Instruments
            {
                Name = "Drums",
                Type = "Percussion Instrument",
                Image = "drums.png"
            },

            new Instruments
            {
                Name = "Ocarina",
                Type = "Wind Instrument",
                Image = "ocraina.png"
            },

            new Instruments
            {
                Name = "Organ",
                Type = "Keyboard Instrument",
                Image = "organ.png"
            },

            new Instruments
            {
                Name = "Piano",
                Type = "Keyboard Instrument",
                Image = "piano.png"
            },

            new Instruments
            {
                Name = "Violin",
                Type = "String Instrument",
                Image = "violin.png"
            }
        };

        CreateInstrumentList();
    }

    private void CreateInstrumentList()
    {
        foreach (Instruments instrument in InstrumentList)
        {
            HorizontalStackLayout row = new HorizontalStackLayout
            {
                Spacing = 15,
                Padding = 10
            };

            Image image = new Image
            {
                Source = instrument.Image,
                HeightRequest = 70,
                WidthRequest = 70,
                Aspect = Aspect.AspectFit
            };

            VerticalStackLayout textLayout = new VerticalStackLayout
            {
                VerticalOptions = LayoutOptions.Center
            };

            Label name = new Label
            {
                Text = instrument.Name,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold
            };

            Label type = new Label
            {
                Text = instrument.Type,
                FontSize = 16,
                TextColor = Colors.Gray
            };

            textLayout.Children.Add(name);
            textLayout.Children.Add(type);

            row.Children.Add(image);
            row.Children.Add(textLayout);

            InstrumentLayout.Children.Add(row);
        }
    }
}