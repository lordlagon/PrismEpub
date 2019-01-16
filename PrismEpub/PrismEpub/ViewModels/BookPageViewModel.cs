using Prism.Commands;
using Prism.Navigation;

namespace PrismEpub.ViewModels
{
    public class BookPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private string _texto;
        public string Texto
        {
            get { return _texto; }
            set { SetProperty(ref _texto, value); }
        }

        public DelegateCommand ProfileCommand { get; set; }

        public BookPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;

            Title = "Book Page";

            Texto = @"Caros amigos, a hegemonia do ambiente político nos obriga à análise das direções preferenciais no sentido do progresso. Por outro lado, a consolidação das estruturas agrega valor ao estabelecimento dos relacionamentos verticais entre as hierarquias. Nunca é demais lembrar o peso e o significado destes problemas, uma vez que a necessidade de renovação processual faz parte de um processo de gerenciamento do fluxo de informações. No entanto, não podemos esquecer que o início da atividade geral de formação de atitudes acarreta um processo de reformulação e modernização do processo de comunicação como um todo. 
                    É claro que o novo modelo estrutural aqui preconizado garante a contribuição de um grupo importante na determinação das novas proposições.Do mesmo modo, o desenvolvimento contínuo de distintas formas de atuação facilita a criação das diretrizes de desenvolvimento para o futuro. Gostaria de enfatizar que a constante divulgação das informações estende o alcance e a importância do sistema de formação de quadros que corresponde às necessidades. Todavia, a consulta aos diversos militantes exige a precisão e a definição das condições financeiras e administrativas exigidas.
                    Acima de tudo, é fundamental ressaltar que a crescente influência da mídia oferece uma interessante oportunidade para verificação do sistema de participação geral.O incentivo ao avanço tecnológico, assim como o aumento do diálogo entre os diferentes setores produtivos causa impacto indireto na reavaliação das diversas correntes de pensamento.Não obstante, a mobilidade dos capitais internacionais talvez venha a ressaltar a relatividade dos conhecimentos estratégicos para atingir a excelência.Evidentemente, o desafiador cenário globalizado obstaculiza a apreciação da importância das condições inegavelmente apropriadas.";

            ProfileCommand = new DelegateCommand(ExecuteProfileCommand);

        }


        private async void ExecuteProfileCommand()
        {
         
            await _navigationService.NavigateAsync("PrismContentPage1");
        }
    }
}