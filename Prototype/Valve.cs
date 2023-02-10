using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
    {
    public class Valve : IComponent
        {
        private int _flow;
        private string _error;

        public Valve (int flow)
            {
            this._flow = flow;
            }

        public int Flow
            {
            get
                {
                return _flow;
                }
            }

        public string Error
            {
            get
                {
                return _error;
                }
            }

        public IComponent Clone ()
            {
            Valve newValve = new Valve(this._flow)
                {
                _error = this._error
                };

            return newValve;
            }

        public void Render ()
            {
            Console.WriteLine("Rendering a Valve");
            this._error = "Error";
            }
        }
    }
