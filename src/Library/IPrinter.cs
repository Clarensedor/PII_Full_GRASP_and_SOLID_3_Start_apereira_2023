using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
        /*
        File printer y consoleprinter implementan SRP imprimen lo de las otras clases
        sin meter mano  y en cambio son recibidas.
        La interfaz  de Iprinter cumple con el patron OCP ya que no importa si quiero imprimirlo en distintos lugares no modifico las otras
        clases como estaba en la de AllinOnePrinter.
        y siendo sincero el que leyo pal irat practicamente es cambiar Sale Por recipe :D
        */
        
    {
        void PrintRecipe(Recipe recipe);  
    }
}
