using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public interface IVerticalMovable
    {
        public void MoveUp();
        public void MoveDown();
    }
    public interface IHorizontalMovable
    {
        public void MoveRight();    
        public void MoveLeft();
    }
}
