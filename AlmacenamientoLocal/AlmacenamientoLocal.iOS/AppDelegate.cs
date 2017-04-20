using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace AlmacenamientoLocal.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication iOSapp, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

			var app = new App();

			app.Contexto.NuevaConexion = () =>
			{
				var fileName = "almacenamiento.db3";
				var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				var libraryPath = System.IO.Path.Combine(documentsPath, "..", "Library");
				var path = System.IO.Path.Combine(libraryPath, fileName);

				var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
				var connection = new SQLite.Net.SQLiteConnection(platform, path);

				return connection;
			};
            LoadApplication(app);

            return base.FinishedLaunching(iOSapp, options);
        }
    }
}
