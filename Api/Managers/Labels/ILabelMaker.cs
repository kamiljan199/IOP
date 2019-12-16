using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Managers.Labels
{
    interface ILabelMaker
    {
        public void MakeLabel(string filePath);
    }
}
