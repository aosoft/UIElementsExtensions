

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UIElementsExtensions
{
    public static class VisualElementExtensions2
    {
        public static T Child<T>(this T self, VisualElement child) where T : VisualElement
        {
            self.Add(child);
            return self;
        }

        public static T Style<T>(this T self, Action<IStyle> fn) where T : VisualElement
        {
            fn(self.style);
            return self;
        }

        public static T Modify<T>(this T self, Action<T> fn) where T : VisualElement
        {
            fn(self);
            return self;
        }
    }

    public static class BaseFieldExtensions2
    {
        public static T ValueChanged<T, TValueType>(this T self, Action<T, TValueType> h) where T: BaseField<TValueType>
        {
            self.RegisterCallback(new EventCallback<ChangeEvent<TValueType>>(e => h(self, e.newValue)));
            return self;
        }
    }

    public static class BindableElementExtensions
    {

        public static T Binding<T>(this T self, IBinding value) where T: BindableElement 
        {
            self.binding = value;
            return self;
        }

        public static T BindingPath<T>(this T self, string value) where T: BindableElement 
        {
            self.bindingPath = value;
            return self;
        }


    }

    public static class FocusableExtensions
    {

        public static T Focusable<T>(this T self, bool value) where T: Focusable 
        {
            self.focusable = value;
            return self;
        }

        public static T TabIndex<T>(this T self, int value) where T: Focusable 
        {
            self.tabIndex = value;
            return self;
        }

        public static T DelegatesFocus<T>(this T self, bool value) where T: Focusable 
        {
            self.delegatesFocus = value;
            return self;
        }


    }

    public static class IMGUIContainerExtensions
    {

        public static T OnGUIHandler<T>(this T self, Action value) where T: IMGUIContainer 
        {
            self.onGUIHandler = value;
            return self;
        }

        public static T CullingEnabled<T>(this T self, bool value) where T: IMGUIContainer 
        {
            self.cullingEnabled = value;
            return self;
        }

        public static T ContextType<T>(this T self, ContextType value) where T: IMGUIContainer 
        {
            self.contextType = value;
            return self;
        }


    }

    public static class ImmediateModeElementExtensions
    {

        public static T CullingEnabled<T>(this T self, bool value) where T: ImmediateModeElement 
        {
            self.cullingEnabled = value;
            return self;
        }


    }

    public static class TemplateContainerExtensions
    {


    }

    public static class TextElementExtensions
    {

        public static T Text<T>(this T self, string value) where T: TextElement 
        {
            self.text = value;
            return self;
        }

        public static T DisplayTooltipWhenElided<T>(this T self, bool value) where T: TextElement 
        {
            self.displayTooltipWhenElided = value;
            return self;
        }


    }

    public static class VisualElementExtensions
    {

        public static T ViewDataKey<T>(this T self, string value) where T: VisualElement 
        {
            self.viewDataKey = value;
            return self;
        }

        public static T UserData<T>(this T self, object value) where T: VisualElement 
        {
            self.userData = value;
            return self;
        }

        public static T UsageHints<T>(this T self, UsageHints value) where T: VisualElement 
        {
            self.usageHints = value;
            return self;
        }

        public static T PickingMode<T>(this T self, PickingMode value) where T: VisualElement 
        {
            self.pickingMode = value;
            return self;
        }

        public static T Name<T>(this T self, string value) where T: VisualElement 
        {
            self.name = value;
            return self;
        }

        public static T Visible<T>(this T self, bool value) where T: VisualElement 
        {
            self.visible = value;
            return self;
        }

        public static T GenerateVisualContent<T>(this T self, Action<MeshGenerationContext> value) where T: VisualElement 
        {
            self.generateVisualContent = value;
            return self;
        }

        public static T CacheAsBitmap<T>(this T self, bool value) where T: VisualElement 
        {
            self.cacheAsBitmap = value;
            return self;
        }

        public static T Tooltip<T>(this T self, string value) where T: VisualElement 
        {
            self.tooltip = value;
            return self;
        }


    }

    public static class BaseFieldExtensions
    {

        public static T Value<T, TValueType>(this T self, TValueType value) where T: BaseField<TValueType> 
        {
            self.value = value;
            return self;
        }

        public static T Label<T, TValueType>(this T self, string value) where T: BaseField<TValueType> 
        {
            self.label = value;
            return self;
        }


    }

    public static class BaseSliderExtensions
    {

        public static T LowValue<T, TValueType>(this T self, TValueType value) where T: BaseSlider<TValueType> where TValueType: IComparable<TValueType>
        {
            self.lowValue = value;
            return self;
        }

        public static T HighValue<T, TValueType>(this T self, TValueType value) where T: BaseSlider<TValueType> where TValueType: IComparable<TValueType>
        {
            self.highValue = value;
            return self;
        }

        public static T PageSize<T, TValueType>(this T self, float value) where T: BaseSlider<TValueType> where TValueType: IComparable<TValueType>
        {
            self.pageSize = value;
            return self;
        }

        public static T ShowInputField<T, TValueType>(this T self, bool value) where T: BaseSlider<TValueType> where TValueType: IComparable<TValueType>
        {
            self.showInputField = value;
            return self;
        }

        public static T Direction<T, TValueType>(this T self, SliderDirection value) where T: BaseSlider<TValueType> where TValueType: IComparable<TValueType>
        {
            self.direction = value;
            return self;
        }


    }

    public static class BoxExtensions
    {


    }

    public static class ButtonExtensions
    {

        public static T Clickable<T>(this T self, Clickable value) where T: Button 
        {
            self.clickable = value;
            return self;
        }


        public static Button Clicked(this Button self, Action<Button> h)
        {
            self.clicked += () => h(self);
            return self;
        }

    }

    public static class FoldoutExtensions
    {

        public static T Text<T>(this T self, string value) where T: Foldout 
        {
            self.text = value;
            return self;
        }

        public static T Value<T>(this T self, bool value) where T: Foldout 
        {
            self.value = value;
            return self;
        }


    }

    public static class HelpBoxExtensions
    {

        public static T Text<T>(this T self, string value) where T: HelpBox 
        {
            self.text = value;
            return self;
        }

        public static T MessageType<T>(this T self, HelpBoxMessageType value) where T: HelpBox 
        {
            self.messageType = value;
            return self;
        }


    }

    public static class ImageExtensions
    {

        public static T Image<T>(this T self, Texture value) where T: Image 
        {
            self.image = value;
            return self;
        }

        public static T VectorImage<T>(this T self, VectorImage value) where T: Image 
        {
            self.vectorImage = value;
            return self;
        }

        public static T SourceRect<T>(this T self, Rect value) where T: Image 
        {
            self.sourceRect = value;
            return self;
        }

        public static T Uv<T>(this T self, Rect value) where T: Image 
        {
            self.uv = value;
            return self;
        }

        public static T ScaleMode<T>(this T self, ScaleMode value) where T: Image 
        {
            self.scaleMode = value;
            return self;
        }

        public static T TintColor<T>(this T self, Color value) where T: Image 
        {
            self.tintColor = value;
            return self;
        }


    }

    public static class LabelExtensions
    {


    }

    public static class ListViewExtensions
    {

        public static T ItemsSource<T>(this T self, System.Collections.IList value) where T: ListView 
        {
            self.itemsSource = value;
            return self;
        }

        public static T MakeItem<T>(this T self, Func<VisualElement> value) where T: ListView 
        {
            self.makeItem = value;
            return self;
        }

        public static T UnbindItem<T>(this T self, Action<VisualElement, int> value) where T: ListView 
        {
            self.unbindItem = value;
            return self;
        }

        public static T BindItem<T>(this T self, Action<VisualElement, int> value) where T: ListView 
        {
            self.bindItem = value;
            return self;
        }

        public static T ItemHeight<T>(this T self, int value) where T: ListView 
        {
            self.itemHeight = value;
            return self;
        }

        public static T ShowBorder<T>(this T self, bool value) where T: ListView 
        {
            self.showBorder = value;
            return self;
        }

        public static T Reorderable<T>(this T self, bool value) where T: ListView 
        {
            self.reorderable = value;
            return self;
        }

        public static T SelectedIndex<T>(this T self, int value) where T: ListView 
        {
            self.selectedIndex = value;
            return self;
        }

        public static T SelectionType<T>(this T self, SelectionType value) where T: ListView 
        {
            self.selectionType = value;
            return self;
        }

        public static T ShowAlternatingRowBackgrounds<T>(this T self, AlternatingRowBackground value) where T: ListView 
        {
            self.showAlternatingRowBackgrounds = value;
            return self;
        }

        public static T ShowBoundCollectionSize<T>(this T self, bool value) where T: ListView 
        {
            self.showBoundCollectionSize = value;
            return self;
        }

        public static T HorizontalScrollingEnabled<T>(this T self, bool value) where T: ListView 
        {
            self.horizontalScrollingEnabled = value;
            return self;
        }


        public static ListView OnItemsChosen(this ListView self, Action<ListView, IEnumerable<object>> h)
        {
            self.onItemsChosen += (a0) => h(self, a0);
            return self;
        }

        public static ListView OnSelectionChange(this ListView self, Action<ListView, IEnumerable<object>> h)
        {
            self.onSelectionChange += (a0) => h(self, a0);
            return self;
        }

    }

    public static class MinMaxSliderExtensions
    {

        public static T MinValue<T>(this T self, float value) where T: MinMaxSlider 
        {
            self.minValue = value;
            return self;
        }

        public static T MaxValue<T>(this T self, float value) where T: MinMaxSlider 
        {
            self.maxValue = value;
            return self;
        }

        public static T LowLimit<T>(this T self, float value) where T: MinMaxSlider 
        {
            self.lowLimit = value;
            return self;
        }

        public static T HighLimit<T>(this T self, float value) where T: MinMaxSlider 
        {
            self.highLimit = value;
            return self;
        }


    }

    public static class PopupWindowExtensions
    {


    }

    public static class RepeatButtonExtensions
    {


    }

    public static class ScrollerExtensions
    {

        public static T Value<T>(this T self, float value) where T: Scroller 
        {
            self.value = value;
            return self;
        }

        public static T LowValue<T>(this T self, float value) where T: Scroller 
        {
            self.lowValue = value;
            return self;
        }

        public static T HighValue<T>(this T self, float value) where T: Scroller 
        {
            self.highValue = value;
            return self;
        }

        public static T Direction<T>(this T self, SliderDirection value) where T: Scroller 
        {
            self.direction = value;
            return self;
        }


        public static Scroller ValueChanged(this Scroller self, Action<Scroller, float> h)
        {
            self.valueChanged += (a0) => h(self, a0);
            return self;
        }

    }

    public static class ScrollViewExtensions
    {

        public static T ShowHorizontal<T>(this T self, bool value) where T: ScrollView 
        {
            self.showHorizontal = value;
            return self;
        }

        public static T ShowVertical<T>(this T self, bool value) where T: ScrollView 
        {
            self.showVertical = value;
            return self;
        }

        public static T ScrollOffset<T>(this T self, Vector2 value) where T: ScrollView 
        {
            self.scrollOffset = value;
            return self;
        }

        public static T HorizontalPageSize<T>(this T self, float value) where T: ScrollView 
        {
            self.horizontalPageSize = value;
            return self;
        }

        public static T VerticalPageSize<T>(this T self, float value) where T: ScrollView 
        {
            self.verticalPageSize = value;
            return self;
        }

        public static T ScrollDecelerationRate<T>(this T self, float value) where T: ScrollView 
        {
            self.scrollDecelerationRate = value;
            return self;
        }

        public static T Elasticity<T>(this T self, float value) where T: ScrollView 
        {
            self.elasticity = value;
            return self;
        }

        public static T TouchScrollBehavior<T>(this T self, ScrollView.TouchScrollBehavior value) where T: ScrollView 
        {
            self.touchScrollBehavior = value;
            return self;
        }


    }

    public static class SliderExtensions
    {


    }

    public static class SliderIntExtensions
    {


    }

    public static class TextFieldExtensions
    {

        public static T Multiline<T>(this T self, bool value) where T: TextField 
        {
            self.multiline = value;
            return self;
        }


    }

    public static class TextInputBaseFieldExtensions
    {

        public static T IsReadOnly<T, TValueType>(this T self, bool value) where T: TextInputBaseField<TValueType> 
        {
            self.isReadOnly = value;
            return self;
        }

        public static T IsPasswordField<T, TValueType>(this T self, bool value) where T: TextInputBaseField<TValueType> 
        {
            self.isPasswordField = value;
            return self;
        }

        public static T MaxLength<T, TValueType>(this T self, int value) where T: TextInputBaseField<TValueType> 
        {
            self.maxLength = value;
            return self;
        }

        public static T DoubleClickSelectsWord<T, TValueType>(this T self, bool value) where T: TextInputBaseField<TValueType> 
        {
            self.doubleClickSelectsWord = value;
            return self;
        }

        public static T TripleClickSelectsLine<T, TValueType>(this T self, bool value) where T: TextInputBaseField<TValueType> 
        {
            self.tripleClickSelectsLine = value;
            return self;
        }

        public static T IsDelayed<T, TValueType>(this T self, bool value) where T: TextInputBaseField<TValueType> 
        {
            self.isDelayed = value;
            return self;
        }

        public static T MaskChar<T, TValueType>(this T self, Char value) where T: TextInputBaseField<TValueType> 
        {
            self.maskChar = value;
            return self;
        }


    }

    public static class ToggleExtensions
    {

        public static T Text<T>(this T self, string value) where T: Toggle 
        {
            self.text = value;
            return self;
        }


    }

    public static class TwoPaneSplitViewExtensions
    {

        public static T FixedPaneIndex<T>(this T self, int value) where T: TwoPaneSplitView 
        {
            self.fixedPaneIndex = value;
            return self;
        }

        public static T FixedPaneInitialDimension<T>(this T self, float value) where T: TwoPaneSplitView 
        {
            self.fixedPaneInitialDimension = value;
            return self;
        }

        public static T Orientation<T>(this T self, TwoPaneSplitViewOrientation value) where T: TwoPaneSplitView 
        {
            self.orientation = value;
            return self;
        }


    }
    public static class StyleExtensions
    {

        public static IStyle AlignContent(this IStyle self, StyleEnum<Align> value)
        {
            self.alignContent = value;
            return self;
        }

        public static IStyle AlignItems(this IStyle self, StyleEnum<Align> value)
        {
            self.alignItems = value;
            return self;
        }

        public static IStyle AlignSelf(this IStyle self, StyleEnum<Align> value)
        {
            self.alignSelf = value;
            return self;
        }

        public static IStyle BackgroundColor(this IStyle self, StyleColor value)
        {
            self.backgroundColor = value;
            return self;
        }

        public static IStyle BackgroundImage(this IStyle self, StyleBackground value)
        {
            self.backgroundImage = value;
            return self;
        }

        public static IStyle BorderBottomColor(this IStyle self, StyleColor value)
        {
            self.borderBottomColor = value;
            return self;
        }

        public static IStyle BorderBottomLeftRadius(this IStyle self, StyleLength value)
        {
            self.borderBottomLeftRadius = value;
            return self;
        }

        public static IStyle BorderBottomRightRadius(this IStyle self, StyleLength value)
        {
            self.borderBottomRightRadius = value;
            return self;
        }

        public static IStyle BorderBottomWidth(this IStyle self, StyleFloat value)
        {
            self.borderBottomWidth = value;
            return self;
        }

        public static IStyle BorderLeftColor(this IStyle self, StyleColor value)
        {
            self.borderLeftColor = value;
            return self;
        }

        public static IStyle BorderLeftWidth(this IStyle self, StyleFloat value)
        {
            self.borderLeftWidth = value;
            return self;
        }

        public static IStyle BorderRightColor(this IStyle self, StyleColor value)
        {
            self.borderRightColor = value;
            return self;
        }

        public static IStyle BorderRightWidth(this IStyle self, StyleFloat value)
        {
            self.borderRightWidth = value;
            return self;
        }

        public static IStyle BorderTopColor(this IStyle self, StyleColor value)
        {
            self.borderTopColor = value;
            return self;
        }

        public static IStyle BorderTopLeftRadius(this IStyle self, StyleLength value)
        {
            self.borderTopLeftRadius = value;
            return self;
        }

        public static IStyle BorderTopRightRadius(this IStyle self, StyleLength value)
        {
            self.borderTopRightRadius = value;
            return self;
        }

        public static IStyle BorderTopWidth(this IStyle self, StyleFloat value)
        {
            self.borderTopWidth = value;
            return self;
        }

        public static IStyle Bottom(this IStyle self, StyleLength value)
        {
            self.bottom = value;
            return self;
        }

        public static IStyle Color(this IStyle self, StyleColor value)
        {
            self.color = value;
            return self;
        }

        public static IStyle Cursor(this IStyle self, StyleCursor value)
        {
            self.cursor = value;
            return self;
        }

        public static IStyle Display(this IStyle self, StyleEnum<DisplayStyle> value)
        {
            self.display = value;
            return self;
        }

        public static IStyle FlexBasis(this IStyle self, StyleLength value)
        {
            self.flexBasis = value;
            return self;
        }

        public static IStyle FlexDirection(this IStyle self, StyleEnum<FlexDirection> value)
        {
            self.flexDirection = value;
            return self;
        }

        public static IStyle FlexGrow(this IStyle self, StyleFloat value)
        {
            self.flexGrow = value;
            return self;
        }

        public static IStyle FlexShrink(this IStyle self, StyleFloat value)
        {
            self.flexShrink = value;
            return self;
        }

        public static IStyle FlexWrap(this IStyle self, StyleEnum<Wrap> value)
        {
            self.flexWrap = value;
            return self;
        }

        public static IStyle FontSize(this IStyle self, StyleLength value)
        {
            self.fontSize = value;
            return self;
        }

        public static IStyle Height(this IStyle self, StyleLength value)
        {
            self.height = value;
            return self;
        }

        public static IStyle JustifyContent(this IStyle self, StyleEnum<Justify> value)
        {
            self.justifyContent = value;
            return self;
        }

        public static IStyle Left(this IStyle self, StyleLength value)
        {
            self.left = value;
            return self;
        }

        public static IStyle MarginBottom(this IStyle self, StyleLength value)
        {
            self.marginBottom = value;
            return self;
        }

        public static IStyle MarginLeft(this IStyle self, StyleLength value)
        {
            self.marginLeft = value;
            return self;
        }

        public static IStyle MarginRight(this IStyle self, StyleLength value)
        {
            self.marginRight = value;
            return self;
        }

        public static IStyle MarginTop(this IStyle self, StyleLength value)
        {
            self.marginTop = value;
            return self;
        }

        public static IStyle MaxHeight(this IStyle self, StyleLength value)
        {
            self.maxHeight = value;
            return self;
        }

        public static IStyle MaxWidth(this IStyle self, StyleLength value)
        {
            self.maxWidth = value;
            return self;
        }

        public static IStyle MinHeight(this IStyle self, StyleLength value)
        {
            self.minHeight = value;
            return self;
        }

        public static IStyle MinWidth(this IStyle self, StyleLength value)
        {
            self.minWidth = value;
            return self;
        }

        public static IStyle Opacity(this IStyle self, StyleFloat value)
        {
            self.opacity = value;
            return self;
        }

        public static IStyle Overflow(this IStyle self, StyleEnum<Overflow> value)
        {
            self.overflow = value;
            return self;
        }

        public static IStyle PaddingBottom(this IStyle self, StyleLength value)
        {
            self.paddingBottom = value;
            return self;
        }

        public static IStyle PaddingLeft(this IStyle self, StyleLength value)
        {
            self.paddingLeft = value;
            return self;
        }

        public static IStyle PaddingRight(this IStyle self, StyleLength value)
        {
            self.paddingRight = value;
            return self;
        }

        public static IStyle PaddingTop(this IStyle self, StyleLength value)
        {
            self.paddingTop = value;
            return self;
        }

        public static IStyle Position(this IStyle self, StyleEnum<Position> value)
        {
            self.position = value;
            return self;
        }

        public static IStyle Right(this IStyle self, StyleLength value)
        {
            self.right = value;
            return self;
        }

        public static IStyle TextOverflow(this IStyle self, StyleEnum<TextOverflow> value)
        {
            self.textOverflow = value;
            return self;
        }

        public static IStyle Top(this IStyle self, StyleLength value)
        {
            self.top = value;
            return self;
        }

        public static IStyle UnityBackgroundImageTintColor(this IStyle self, StyleColor value)
        {
            self.unityBackgroundImageTintColor = value;
            return self;
        }

        public static IStyle UnityBackgroundScaleMode(this IStyle self, StyleEnum<ScaleMode> value)
        {
            self.unityBackgroundScaleMode = value;
            return self;
        }

        public static IStyle UnityFont(this IStyle self, StyleFont value)
        {
            self.unityFont = value;
            return self;
        }

        public static IStyle UnityFontStyleAndWeight(this IStyle self, StyleEnum<FontStyle> value)
        {
            self.unityFontStyleAndWeight = value;
            return self;
        }

        public static IStyle UnityOverflowClipBox(this IStyle self, StyleEnum<OverflowClipBox> value)
        {
            self.unityOverflowClipBox = value;
            return self;
        }

        public static IStyle UnitySliceBottom(this IStyle self, StyleInt value)
        {
            self.unitySliceBottom = value;
            return self;
        }

        public static IStyle UnitySliceLeft(this IStyle self, StyleInt value)
        {
            self.unitySliceLeft = value;
            return self;
        }

        public static IStyle UnitySliceRight(this IStyle self, StyleInt value)
        {
            self.unitySliceRight = value;
            return self;
        }

        public static IStyle UnitySliceTop(this IStyle self, StyleInt value)
        {
            self.unitySliceTop = value;
            return self;
        }

        public static IStyle UnityTextAlign(this IStyle self, StyleEnum<TextAnchor> value)
        {
            self.unityTextAlign = value;
            return self;
        }

        public static IStyle UnityTextOverflowPosition(this IStyle self, StyleEnum<TextOverflowPosition> value)
        {
            self.unityTextOverflowPosition = value;
            return self;
        }

        public static IStyle Visibility(this IStyle self, StyleEnum<Visibility> value)
        {
            self.visibility = value;
            return self;
        }

        public static IStyle WhiteSpace(this IStyle self, StyleEnum<WhiteSpace> value)
        {
            self.whiteSpace = value;
            return self;
        }

        public static IStyle Width(this IStyle self, StyleLength value)
        {
            self.width = value;
            return self;
        }
    }
}
