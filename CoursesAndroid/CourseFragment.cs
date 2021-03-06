using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using CoursesLibrary;
using Android.Support.V4.App;

namespace CoursesAndroid
{
    public class CourseFragment : Fragment
    {
        // decorations
        TextView textTitle;
        ImageView imageCourse;
        TextView textDescription;

        public Course Course { get; set; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // inflate the layout for this view, but don't attach it to the activity,
            // because we're going to return the view and let the activity do it itself
            View rootView = inflater.Inflate(Resource.Layout.CourseFragment, container, false);

            textTitle = rootView.FindViewById<TextView>(Resource.Id.textTitle);
            imageCourse = rootView.FindViewById<ImageView>(Resource.Id.imageCourse);
            textDescription = rootView.FindViewById<TextView>(Resource.Id.textDescription);

            textTitle.Text = Course.Title;
            textDescription.Text = Course.Description;
            imageCourse.SetImageResource(ResourceHelper.TranslateDrawableWithReflection(Course.Image));

            return rootView;
        }
    }
}