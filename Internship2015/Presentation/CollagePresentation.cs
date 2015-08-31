using System;
using University.Presentation.Interface;
using University.Repository.Interface;

namespace University.Presentation
{
    public class CollagePresentation : ICollagePresentation
    {
        private readonly ICollageRepository _collageRepository;

        public CollagePresentation(ICollageRepository collageRepository)
        {
            _collageRepository = collageRepository;
        }

        public void ShowAllCollages()
        {
            var collages = _collageRepository.GetAll();
            foreach (var collage in collages)
            {
                Console.WriteLine(collage);
            }
        }
    }
}
