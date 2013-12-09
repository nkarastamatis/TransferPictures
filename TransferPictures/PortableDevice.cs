using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TransferPictures
{
    public abstract class PortableDeviceObject
    {
        protected PortableDeviceObject(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }
    }
    //Create a descendant of this abstract class to represent a folder.

    public class PortableDeviceFolder : PortableDeviceObject
    {
        public PortableDeviceFolder(string id, string name)
            : base(id, name)
        {
            this.Files = new List<PortableDeviceObject>();
        }

        public IList<PortableDeviceObject> Files { get; set; }
    }
    //Add another class to represent a file.

    public class PortableDeviceFile : PortableDeviceObject
    {
        public PortableDeviceFile(string id, string name)
            : base(id, name)
        { }
    }

    public class PortableDeviceCollection : Collection<PortableDevice>
    {
        private readonly PortableDeviceManager _deviceManager;

        public PortableDeviceCollection()
        {
            this._deviceManager = new PortableDeviceManager();
        }

        public void Refresh()
        {
            //...
        }
    }

    public class PortableDevice 
    {
        public PortableDevice(string deviceId)
        {
            this.DeviceId = deviceId;
        }

        public string DeviceId { get; set; }
        
        public PortableDeviceFolder GetContents()
        {
            var root = new PortableDeviceFolder("DEVICE", "DEVICE");

            IPortableDeviceContent content;
            this._device.Content(out content);
            EnumerateContents(ref content, root);

            return root;
        }
    }
}