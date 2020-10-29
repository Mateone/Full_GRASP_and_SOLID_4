using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    /*
        Creamos la clase EquipmentCatalog, encargada de crear objetos de "Equipment" y guardarlos en una lista (entre otras cosas),
        ya que no tenía sentido que la clase program fuera la encargada de estas responsabilidades. Debido a que los objetos "Equipment"
        son guardados en dicha lista, decidimos que está los cree, aplicando así el patrón Creator.
    */
    public class EquipmentCatalog
    {
        public List<Equipment> Catalog {get; set;}

        public EquipmentCatalog()
        {
            this.Catalog = new List<Equipment>();
        }

        public void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            Catalog.Add(new Equipment(description, hourlyCost));
        }

        public Equipment EquipmentAt(int index)
        {
            return Catalog[index] as Equipment;
        }

        public Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in Catalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }
    }
}