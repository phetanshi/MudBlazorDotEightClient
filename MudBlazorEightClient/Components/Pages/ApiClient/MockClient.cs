using MudBlazorTemplatesPoc.Pages.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks.Sources;

namespace MudBlazorTemplatesPoc.Pages.ApiClient;

public class MockClient
{
    public async Task<List<SkillDto>> GetSkills()
    {
        List<SkillDto> skillList = new List<SkillDto>();
        skillList.Add(new SkillDto { Id = 1, Name = "One" });
        skillList.Add(new SkillDto { Id = 2, Name = "Two" });
        skillList.Add(new SkillDto { Id = 3, Name = "Three" });
        skillList.Add(new SkillDto { Id = 4, Name = "Four" });
        return await Task.FromResult(skillList);
    }
}
