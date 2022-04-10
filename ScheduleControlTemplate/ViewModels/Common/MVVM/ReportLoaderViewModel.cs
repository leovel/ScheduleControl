using System.IO;
using Telerik.Windows.Documents.Fixed;

namespace ScheduleControlTemplate.ViewModels
{
    public class ReportLoaderViewModel : CustomManagementViewModelBase<ReportLoaderViewModel>
    {
        private readonly MemoryStream _stream;

        public ReportLoaderViewModel(byte[] documentSource, IViewModelBase parentViewModel) : base(parentViewModel)
        {
            Title = "GUARDAR OU IMPRIMIR";

            _stream = new MemoryStream(documentSource);
            PdfDocumentSource docSource = new(_stream);
            docSource.Loaded += (sender, args) => { _stream?.Dispose(); };

            DocumentSource = docSource;
        }

        private PdfDocumentSource _documentSource;

        public PdfDocumentSource DocumentSource
        {
            get => _documentSource;
            private set => SetProperty(ref _documentSource, value);
        }
    }
}
