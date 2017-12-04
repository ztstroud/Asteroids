using System.Collections.Generic;
using System.Drawing;

namespace Asteroids
{
    public class Renderable
    {
        /// <summary>
        /// The points of the renderable.
        /// </summary>
        public IEnumerable<PointF> Points { get; private set; }

        /// <summary>
        /// If the renderable is closed.
        /// </summary>
        public bool Closed { get; private set; }

        /// <summary>
        /// Construct a new renderable with the given points, and given closed.
        /// </summary>
        /// 
        /// <param name="points">the points of the renderable</param>
        /// <param name="closed">if the renderable is closed</param>
        public Renderable(IEnumerable<PointF> points, bool closed)
        {
            Points = points;
            Closed = closed;
        }
    }
}
