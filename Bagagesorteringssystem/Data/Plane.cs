using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagagesorteringssystem.Data
{
    public enum PlaneDestination
    {
        None,
        Copenhagen,
        NewYork,
        Paris,
        Rome,
        London,
        Amsterdam,
        Oslo,
        Bergen,
        Stavanger,
        Trondheim,
    }

    public class Plane
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public PlaneDestination Destination { get; private set; }

        public Plane(int id, string name)
        {
            Id = id;
            Name = name;
            Destination = PlaneDestination.None;
        }

        public void SetDestination(PlaneDestination destination)
        {
            Destination = destination;
        }
    }
}
