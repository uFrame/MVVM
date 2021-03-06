using uFrame.Editor.Compiling.CodeGen;
using uFrame.Editor.Graphs.Data;
using uFrame.MVVM.ViewModels;

namespace uFrame.MVVM.Templates
{
    public class _ITEMNAME_VIEWMODEL : _TEMPLATETYPE_
    {
        public string TheType(TemplateContext context)
        {
            return context.Item.Name.AsViewModel();
        }

    }
    public class _REFNAME_VIEWMODEL : _TEMPLATETYPE_
    {
        public string TheType(TemplateContext context)
        {
            var referenceItem = context.Item as GenericReferenceItem;
            if (referenceItem != null)
            {
                return referenceItem.SourceItemObject.Name.AsViewModel();
            }
            return string.Empty;
        }
    }
    
    public class _ITEMNAME_VIEWMODEL2 : ViewModel, _TEMPLATETYPE_
    {
        public string TheType(TemplateContext context)
        {
            return context.Item.Name.AsViewModel();
        }

    }
}