using AppTeste.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppTeste.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    [ObservableProperty]
    IEnumerable<Assessments> _assessments;


    public HomeViewModel()
    {
        Assessments = Get();
    }


    private IEnumerable<Assessments> Get()
    {
        return
        [
            new Assessments { Name = "The Shawshank Redemption" },
            new Assessments { Name = "The Godfather" },
            new Assessments { Name = "The Dark Knight" },
            new Assessments { Name = "Pulp Fiction" },
            new Assessments { Name = "The Lord of the Rings: The Return of the King" },
            new Assessments { Name = "Forrest Gump" },
            new Assessments { Name = "Inception" },
            new Assessments { Name = "Fight Club" },
            new Assessments { Name = "The Matrix" },
            new Assessments { Name = "Goodfellas" }
        ];
    }

    [RelayCommand]
    async Task Detail(object data)
    {
        var query = new Dictionary<string, object>
        {
            { "Data", data }
        };

        var assessment = query["Data"] as Assessments;

        try
        {
            await Shell.Current.DisplayAlert("Message", $"The Name Movie{assessment.Name}", "Ok");
            //await Shell.Current.GoToAsync($"DetailsPage", query);
        }
        catch (Exception ex)
        {
            if (ex.InnerException is not null)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

            Console.WriteLine($"{ex.Message} - {ex.StackTrace}");
        }
    }
}
