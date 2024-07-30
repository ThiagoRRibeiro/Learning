﻿using Microsoft.Extensions.Logging;
using People.Data;

namespace People
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            string dbPath = FileAccessHelper.GetLocalFilePath("people.db3");
            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<PersonRepository>(s, dbPath));

            return builder.Build();
        }
    }
}
