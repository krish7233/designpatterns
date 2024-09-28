namespace designpatterns.abstractfactorydesignpattern
{
    public interface IButton
    {
        void Paint();
    }

    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("paint windows button.");
        }
    }

    public class MacOSButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("paint macos button.");
        }
    }

    public class LinuxButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("paint linux button.");
        }
    }

    public interface ICheckBox
    {
        void Paint();
    }

    public class WindowsCheckbox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("paint windows checkbox");
        }
    }

    public class MacOSCheckbox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("paint macos checkbox");
        }
    }

    public class LinuxCheckbox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("paint linux checkbox");
        }
    }

    public interface IPanel
    {
        void Paint();
    }

    public class WindowsPanel : IPanel
    {
        public void Paint()
        {
            Console.WriteLine("paint windows panel");
        }
    }

    public class MacOSPanel : IPanel
    {
        public void Paint()
        {
            Console.WriteLine("paint macos panel");
        }
    }

    public class LinuxPanel : IPanel
    {
        public void Paint()
        {
            Console.WriteLine("paint linux panel");
        }
    }

    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
        IPanel CreatePanel();
    }


    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WindowsCheckbox();
        }

        public IPanel CreatePanel()
        {
            return new WindowsPanel();
        }
    }


    public class MacOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacOSCheckbox();
        }

        public IPanel CreatePanel()
        {
            return new MacOSPanel();
        }
    }

    public class LinuxFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new LinuxCheckbox();
        }

        public IPanel CreatePanel()
        {
            return new LinuxPanel();
        }
    }



    internal class Program
    {
        private static void Main(string[] args)
        {
            IGUIFactory windowsFactory = new WindowsFactory();
            windowsFactory.CreateButton().Paint();
            windowsFactory.CreateCheckBox().Paint();
            windowsFactory.CreatePanel().Paint();

            Console.WriteLine("producing MacOS GUI");

            IGUIFactory macOSFactory = new MacOSFactory();
            macOSFactory.CreateButton().Paint();
            macOSFactory.CreateCheckBox().Paint();
            macOSFactory.CreatePanel().Paint();


            Console.WriteLine("Hello, World!");
        }
    }
}