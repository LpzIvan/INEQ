#region using directives
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace DataAccesLayer
{
    public class EquipmentTypeDAL
    {
        private static IneqEntities db = new IneqEntities();

        /// <summary>
        /// Este metodo sirve para mandar llamar toda la lista de la tabla
        /// </summary>
        /// <returns></returns>

        public static List<EquipmentType> getALL()
        {
            return db.EquipmentTypes.ToList();
        }

        /// <summary>
        /// Este metodo sirve para consultar los registros filtrados por la descripcion de la tabla EquipmentType
        /// </summary>
        /// <param name="descripcion"></param>
        /// <returns>Lista</returns>
        public static List<EquipmentType> getByDescription(string descripcion)
        {
            return db.EquipmentTypes.Where(e => e.Description == descripcion).ToList();
        } 

        /// <summary>
        /// Este metodo sirve para insertar un registro en la tabla equipmentType
        /// </summary>
        /// <param name="et">Objeto EquipmentType</param>
        /// <returns>Boolean</returns>
        public static bool addEquipmentType(EquipmentType et)
        {
            db.EquipmentTypes.Add(et); // lo agrega
            return db.SaveChanges() > 0; //lo refresca
        }

        /// <summary>
        /// Este metodo sirve para actualizar un registro de la tabla EquipmentType
        /// </summary>
        /// <param name="et">Objeto EquipmentType</param>
        /// <returns>Boolean</returns>
        public static bool updateEquipmentType( EquipmentType et)
        {
            db.EquipmentTypes.Attach(et);
            db.Entry(et).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
