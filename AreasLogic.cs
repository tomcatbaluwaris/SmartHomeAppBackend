namespace SmartHomeAppBackend;

public class AreasLogic
{
    private Area[] _areas;

    public IEnumerable<Area> GetAllAreas()
    {
            _areas = new Area[] { new Area() };
            return _areas;
    }
}