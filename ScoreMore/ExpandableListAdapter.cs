using System;
using System.Collections.Generic;

using Android.Widget;
using Android.Content;
using Android.Views;

using ScoreMoreLib;

namespace ScoreMore
{
	public class ExpandableListAdapter : BaseExpandableListAdapter
	{
		//attributes
		private Context context;

		//Lists, 1 voor de headers, 1 voor de subitems
		private List<Onderwerp> headers;
		private Dictionary<Onderwerp, List<Onderwerp>> subOnderwerpen;

		public ExpandableListAdapter (Context context, List<Onderwerp> headers, Dictionary<Onderwerp, List<Onderwerp>> subOnderwerpen);
		{
			this.context = context;
			this.headers = headers;
			this.subOnderwerpen = subOnderwerpen;
		}

		@Override
		public Object getChild(int groupPosition, int childPosititon) {
			return this.subOnderwerpen [this.headers [groupPosition]];
		}

		@Override
		public long getChildId(int groupPosition, int childPosition) {
			return childPosition;
		}

		@Override
		public View getChildView(int groupPosition, final int childPosition,
			boolean isLastChild, View convertView, ViewGroup parent) {

			String childText = (String) getChild(groupPosition, childPosition);

			if (convertView == null) {
				LayoutInflater infalInflater = (LayoutInflater) this._context
					.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
				convertView = infalInflater.inflate(R.layout.list_item, null);
			}

			TextView txtListChild = (TextView) convertView
				.findViewById(R.id.lblListItem);

			txtListChild.setText(childText);
			return convertView;
		}

		@Override
		public int getChildrenCount(int groupPosition) {
			return this._listDataChild.get(this._listDataHeader.get(groupPosition))
				.size();
		}

		@Override
		public Object getGroup(int groupPosition) {
			return this._listDataHeader.get(groupPosition);
		}

		@Override
		public int getGroupCount() {
			return this._listDataHeader.size();
		}

		@Override
		public long getGroupId(int groupPosition) {
			return groupPosition;
		}

		@Override
		public View getGroupView(int groupPosition, boolean isExpanded,
			View convertView, ViewGroup parent) {
			String headerTitle = (String) getGroup(groupPosition);
			if (convertView == null) {
				LayoutInflater infalInflater = (LayoutInflater) this._context
					.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
				convertView = infalInflater.inflate(R.layout.list_group, null);
			}

			TextView lblListHeader = (TextView) convertView
				.findViewById(R.id.lblListHeader);
			lblListHeader.setTypeface(null, Typeface.BOLD);
			lblListHeader.setText(headerTitle);

			return convertView;
		}

		@Override
		public boolean hasStableIds() {
			return false;
		}

		@Override
		public boolean isChildSelectable(int groupPosition, int childPosition) {
			return true;
		}
	}
}

