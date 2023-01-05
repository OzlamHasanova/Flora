using Core.Entities;

namespace FiorelloMvc.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<SlideBg> SlideBgs { get; set; } = null!;
        public IEnumerable<SlideDesc> SlideDescs { get; set; } = null!;
    }
}
