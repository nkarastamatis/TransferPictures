using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferPictures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TransferPicturesForm());
        }
    }

    

    //private static PortableDeviceObject WrapObject(IPortableDeviceProperties properties, string objectId)
    //    {
    //        PortableDeviceApiLib.IPortableDeviceKeyCollection keys;
    //        properties.GetSupportedProperties(objectId, out keys);

    //        PortableDeviceApiLib.IPortableDeviceValues values;
    //        properties.GetValues(objectId, keys, out values);

    //        // Get the name of the object
    //        string name;
    //        var property = new PortableDeviceApiLib._tagpropertykey();
    //        property.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
    //        property.pid = 4;
    //        values.GetStringValue(property, out name);

    //        // Get the type of the object
    //        Guid contentType;
    //        property = new PortableDeviceApiLib._tagpropertykey();
    //        property.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
    //        property.pid = 7;
    //        values.GetGuidValue(property, out contentType);

    //        var folderType = new Guid(0x27E2E392, 0xA111, 0x48E0, 0xAB, 0x0C, 0xE1, 0x77, 0x05, 0xA0, 0x5F, 0x85);
    //        var functionalType = new Guid(0x99ED0160, 0x17FF, 0x4C44, 0x9D, 0x98, 0x1D, 0x7A, 0x6F, 0x94, 0x19, 0x21);          

    //        if (contentType == folderType || contentType == functionalType)
    //        {
    //            return new PortableDeviceFolder(objectId, name);
    //        }

    //        return new PortableDeviceFile(objectId, name);
    //    }
}
