﻿namespace Soundfingerprinting.DuplicatesDetector.Services
{
    using Soundfingerprinting.Audio.Services;
    using Soundfingerprinting.DuplicatesDetector.DataAccess;
    using Soundfingerprinting.Fingerprinting.WorkUnitBuilder;
    using Soundfingerprinting.Hashing;

    /// <summary>
    ///   Service injector loads all the services into Service Container on Application startup
    /// </summary>
    /// <remarks>
    ///   Dependency injection with Service Locator
    /// </remarks>
    public static class ServiceInjector
    {
        /// <summary>
        ///   Add bindings that will be applied within the application runtime
        /// </summary>
        public static void InjectServices()
        {
            ServiceContainer.Kernel.Bind<IFolderBrowserDialogService>().To<FolderBrowserDialogService>();
            ServiceContainer.Kernel.Bind<IMessageBoxService>().To<MessageBoxService>();
            ServiceContainer.Kernel.Bind<IOpenFileDialogService>().To<OpenFileDialogService>();
            ServiceContainer.Kernel.Bind<ISaveFileDialogService>().To<SaveFileDialogService>();
            ServiceContainer.Kernel.Bind<IWindowService>().To<WindowService>();
            ServiceContainer.Kernel.Bind<IGenericViewWindow>().To<GenericViewWindowService>();
            ServiceContainer.Kernel.Bind<IStorage>().To<RamStorage>();
            ServiceContainer.Kernel.Bind<IWorkUnitBuilder>().To<WorkUnitBuilder>();
            ServiceContainer.Kernel.Bind<IPermutations>().To<LocalPermutations>();
            ServiceContainer.Kernel.Bind<IAudioService>().To<BassAudioService>().InSingletonScope();
        }
    }
}