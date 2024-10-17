[ApiController]
[Route("api/[controller]")]
public class EnfermedadController: ControllerBase
{
    private readonly IEnfermedadService_enfermedadService;

    public EnfermedadController(IEnfermedadService enfermedadService)
    
}

[HttpPost]
public IActionResult CreateUpdate(Enfermedad enfermedad)
{
    _enfermedadService.Save(enfermedad);
    return Ok();
} 

[HttpPost("{taratamientoId/medicamento/{medicamentoId}")]
public IActionResult AssociateTreatmentToMedication(int taratamientoId, int medicamentoId)
{
    _enfermedadService.AssociateTreatmentToMedication(int taratamientoId, int medicamentoId)
    return Ok(tratamientos);
}

[HttpPost("enfermedades")]
public IActionResult GetDiseases([FromQuery] string filter, [FronQuery] int page = 1, [FromQuery] int pageSize =  10)
{
    var enfermedades = _enfermedadService.GetDiseases(filter, page, pageSize);
    return Ok(enfermedades);
}