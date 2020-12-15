using System;
using System.Collections.Generic;
using System.Text;

namespace Solution1
{
    public interface Observer
    {
        public void Update(int temperature, int pressure, int humidity);

    }

}
