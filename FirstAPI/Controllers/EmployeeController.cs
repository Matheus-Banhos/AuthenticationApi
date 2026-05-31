using FirstAPI.Model;
using FirstAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers;

[ApiController]
[Route("api/v1/controller")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    
    [HttpPost]
    public IActionResult Add(EmployeeViewModel employeeViewModel)
    {
        var employee = new Employee(employeeViewModel.Name, employeeViewModel.Age, null);
        _employeeRepository.Add(employee);
        return Ok();
    }

    [HttpGet]
    public IActionResult Get()
    {
        var employees = _employeeRepository.Get();
        return Ok(employees);
    }
}