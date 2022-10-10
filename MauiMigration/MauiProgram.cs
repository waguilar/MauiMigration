﻿using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MauiMigration;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCompatibility();

		return builder.Build();
	}
}
