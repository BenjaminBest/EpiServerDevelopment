namespace EpiServerDevelopment.Features.GlobalLayout
{
    /// <summary>
    /// The interface IControllerSupportsLayout defines a method which may be invoked by PageContextActionFilter allowing controllers
    /// to modify common layout properties of the view model.
    /// </summary>
    public interface IControllerSupportsLayout
    {
        /// <summary>
        /// Modifies the layout.
        /// </summary>
        /// <param name="layoutModel">The layout model.</param>
        void AdjustLayout(LayoutModel layoutModel);
    }
}