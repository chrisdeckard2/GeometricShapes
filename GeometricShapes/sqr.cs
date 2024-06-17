using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes;
internal class sqr {

    public int Side {  get; set; } = 0;

    public int Perimeter() {
        return 4 * Side;

    }

    public int Area() {
        return Side * Side;
    }

    public sqr(int side) {
        side = side;

    }
}
