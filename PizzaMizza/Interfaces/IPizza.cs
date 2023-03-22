using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Interfaces
{
    public interface IPizza<Pizza> where Pizza: class, new()
    {
        public void Create(Pizza pizza);
        public void Show();
    
    }
}
