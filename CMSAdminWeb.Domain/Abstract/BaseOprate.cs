using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Abstract
{
    public interface BaseOprate
    {
          object AddElem(object elem);
          void DeletElem(object elem);
          void EditElem(object elem);
    }
}
