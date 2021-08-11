

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

        public static T AlignContent<T>(this T self, StyleEnum<Align> value) where T : VisualElement
        {
            self.style.alignContent = value;
            return self;
        }

        public static T AlignItems<T>(this T self, StyleEnum<Align> value) where T : VisualElement
        {
            self.style.alignItems = value;
            return self;
        }

        public static T AlignSelf<T>(this T self, StyleEnum<Align> value) where T : VisualElement
        {
            self.style.alignSelf = value;
            return self;
        }

        public static T BackgroundColor<T>(this T self, StyleColor value) where T : VisualElement
        {
            self.style.backgroundColor = value;
            return self;
        }

        public static T BackgroundImage<T>(this T self, StyleBackground value) where T : VisualElement
        {
            self.style.backgroundImage = value;
            return self;
        }

        public static T BorderBottomColor<T>(this T self, StyleColor value) where T : VisualElement
        {
            self.style.borderBottomColor = value;
            return self;
        }

        public static T BorderBottomLeftRadius<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.borderBottomLeftRadius = value;
            return self;
        }

        public static T BorderBottomRightRadius<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.borderBottomRightRadius = value;
            return self;
        }

        public static T BorderBottomWidth<T>(this T self, StyleFloat value) where T : VisualElement
        {
            self.style.borderBottomWidth = value;
            return self;
        }

        public static T BorderLeftColor<T>(this T self, StyleColor value) where T : VisualElement
        {
            self.style.borderLeftColor = value;
            return self;
        }

        public static T BorderLeftWidth<T>(this T self, StyleFloat value) where T : VisualElement
        {
            self.style.borderLeftWidth = value;
            return self;
        }

        public static T BorderRightColor<T>(this T self, StyleColor value) where T : VisualElement
        {
            self.style.borderRightColor = value;
            return self;
        }

        public static T BorderRightWidth<T>(this T self, StyleFloat value) where T : VisualElement
        {
            self.style.borderRightWidth = value;
            return self;
        }

        public static T BorderTopColor<T>(this T self, StyleColor value) where T : VisualElement
        {
            self.style.borderTopColor = value;
            return self;
        }

        public static T BorderTopLeftRadius<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.borderTopLeftRadius = value;
            return self;
        }

        public static T BorderTopRightRadius<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.borderTopRightRadius = value;
            return self;
        }

        public static T BorderTopWidth<T>(this T self, StyleFloat value) where T : VisualElement
        {
            self.style.borderTopWidth = value;
            return self;
        }

        public static T Bottom<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.bottom = value;
            return self;
        }

        public static T Color<T>(this T self, StyleColor value) where T : VisualElement
        {
            self.style.color = value;
            return self;
        }

        public static T Cursor<T>(this T self, StyleCursor value) where T : VisualElement
        {
            self.style.cursor = value;
            return self;
        }

        public static T Display<T>(this T self, StyleEnum<DisplayStyle> value) where T : VisualElement
        {
            self.style.display = value;
            return self;
        }

        public static T FlexBasis<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.flexBasis = value;
            return self;
        }

        public static T FlexDirection<T>(this T self, StyleEnum<FlexDirection> value) where T : VisualElement
        {
            self.style.flexDirection = value;
            return self;
        }

        public static T FlexGrow<T>(this T self, StyleFloat value) where T : VisualElement
        {
            self.style.flexGrow = value;
            return self;
        }

        public static T FlexShrink<T>(this T self, StyleFloat value) where T : VisualElement
        {
            self.style.flexShrink = value;
            return self;
        }

        public static T FlexWrap<T>(this T self, StyleEnum<Wrap> value) where T : VisualElement
        {
            self.style.flexWrap = value;
            return self;
        }

        public static T FontSize<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.fontSize = value;
            return self;
        }

        public static T Height<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.height = value;
            return self;
        }

        public static T JustifyContent<T>(this T self, StyleEnum<Justify> value) where T : VisualElement
        {
            self.style.justifyContent = value;
            return self;
        }

        public static T Left<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.left = value;
            return self;
        }

        public static T MarginBottom<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.marginBottom = value;
            return self;
        }

        public static T MarginLeft<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.marginLeft = value;
            return self;
        }

        public static T MarginRight<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.marginRight = value;
            return self;
        }

        public static T MarginTop<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.marginTop = value;
            return self;
        }

        public static T MaxHeight<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.maxHeight = value;
            return self;
        }

        public static T MaxWidth<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.maxWidth = value;
            return self;
        }

        public static T MinHeight<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.minHeight = value;
            return self;
        }

        public static T MinWidth<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.minWidth = value;
            return self;
        }

        public static T Opacity<T>(this T self, StyleFloat value) where T : VisualElement
        {
            self.style.opacity = value;
            return self;
        }

        public static T Overflow<T>(this T self, StyleEnum<Overflow> value) where T : VisualElement
        {
            self.style.overflow = value;
            return self;
        }

        public static T PaddingBottom<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.paddingBottom = value;
            return self;
        }

        public static T PaddingLeft<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.paddingLeft = value;
            return self;
        }

        public static T PaddingRight<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.paddingRight = value;
            return self;
        }

        public static T PaddingTop<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.paddingTop = value;
            return self;
        }

        public static T Position<T>(this T self, StyleEnum<Position> value) where T : VisualElement
        {
            self.style.position = value;
            return self;
        }

        public static T Right<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.right = value;
            return self;
        }

        public static T TextOverflow<T>(this T self, StyleEnum<TextOverflow> value) where T : VisualElement
        {
            self.style.textOverflow = value;
            return self;
        }

        public static T Top<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.top = value;
            return self;
        }

        public static T UnityBackgroundImageTintColor<T>(this T self, StyleColor value) where T : VisualElement
        {
            self.style.unityBackgroundImageTintColor = value;
            return self;
        }

        public static T UnityBackgroundScaleMode<T>(this T self, StyleEnum<ScaleMode> value) where T : VisualElement
        {
            self.style.unityBackgroundScaleMode = value;
            return self;
        }

        public static T UnityFont<T>(this T self, StyleFont value) where T : VisualElement
        {
            self.style.unityFont = value;
            return self;
        }

        public static T UnityFontStyleAndWeight<T>(this T self, StyleEnum<FontStyle> value) where T : VisualElement
        {
            self.style.unityFontStyleAndWeight = value;
            return self;
        }

        public static T UnityOverflowClipBox<T>(this T self, StyleEnum<OverflowClipBox> value) where T : VisualElement
        {
            self.style.unityOverflowClipBox = value;
            return self;
        }

        public static T UnitySliceBottom<T>(this T self, StyleInt value) where T : VisualElement
        {
            self.style.unitySliceBottom = value;
            return self;
        }

        public static T UnitySliceLeft<T>(this T self, StyleInt value) where T : VisualElement
        {
            self.style.unitySliceLeft = value;
            return self;
        }

        public static T UnitySliceRight<T>(this T self, StyleInt value) where T : VisualElement
        {
            self.style.unitySliceRight = value;
            return self;
        }

        public static T UnitySliceTop<T>(this T self, StyleInt value) where T : VisualElement
        {
            self.style.unitySliceTop = value;
            return self;
        }

        public static T UnityTextAlign<T>(this T self, StyleEnum<TextAnchor> value) where T : VisualElement
        {
            self.style.unityTextAlign = value;
            return self;
        }

        public static T UnityTextOverflowPosition<T>(this T self, StyleEnum<TextOverflowPosition> value) where T : VisualElement
        {
            self.style.unityTextOverflowPosition = value;
            return self;
        }

        public static T Visibility<T>(this T self, StyleEnum<Visibility> value) where T : VisualElement
        {
            self.style.visibility = value;
            return self;
        }

        public static T WhiteSpace<T>(this T self, StyleEnum<WhiteSpace> value) where T : VisualElement
        {
            self.style.whiteSpace = value;
            return self;
        }

        public static T Width<T>(this T self, StyleLength value) where T : VisualElement
        {
            self.style.width = value;
            return self;
        }
    }
}
