using SmartHomeAppBackend;

namespace SmartHomeAppBackend;

public class AreasLogic
{
    private Area[] _areas;

    public IEnumerable<Area> GetAllAreas()
    {
            _areas = new Area[]
            {
                new Area(){ Id = 1, Name = "Wohnzimmer"},
                new Area(){ Id = 2, Name = "Schlafzimmer"},
                new Area(){ Id = 3, Name = "Küche"}
            };
            return _areas;
    }
}