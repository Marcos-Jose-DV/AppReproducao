using AppTeste.Models;
using CommunityToolkit.Mvvm.ComponentModel;

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
}
