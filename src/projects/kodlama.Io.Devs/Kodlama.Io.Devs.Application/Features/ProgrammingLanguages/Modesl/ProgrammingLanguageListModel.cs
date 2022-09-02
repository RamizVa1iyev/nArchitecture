using Core.Persistence.Paging;
using Kodlama.Io.Devs.Application.Features.ProgrammingLanguages.Dtos;

namespace Kodlama.Io.Devs.Application.Features.ProgrammingLanguages.Modesl
{
    public class ProgrammingLanguageListModel: BasePageableModel
    {
        public IList<ProgrammingLanguageListDto> Items { get; set; }
    }
}
