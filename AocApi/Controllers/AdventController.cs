using System.Net;
using System.Net.Mime;
using System.Reflection;
using AocApi.Helpers;
using Domain.DataModels;
using Microsoft.AspNetCore.Mvc;
using Services.AdventServices;

namespace AocApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AdventController : ControllerBase
{
    [HttpGet("{name:alpha}/{year:int}/{day:int}")]
    [Consumes(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ApiResponse> GetSolutions(string name, int year, int day)
    {
        var serviceNamespace = $"Services.AdventServices.{WordHelpers.Capitalise(name)}._{year}";
        var className = $"{serviceNamespace}.{WordHelpers.GetNumberWord(day)}Solution";
        var assem = Assembly.Load("Services");
        var classType = assem.GetType(className);

        if (classType == null)
        {
            return NotFound(ApiResponse.Make());
        }

        var solution = (ISolution?)Activator.CreateInstance(classType);
        return solution == null
            ? NotFound(ApiResponse.Make())
            : ApiResponse.Make(solution.GetPartOneSolution(), solution.GetPartTwoSolution());
    }
}