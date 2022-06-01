import android.content.Context;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.applistview.R;
import com.example.applistview.UserAccount;

import java.util.List;

public class CustomListAdapter extends BaseAdapter {

    private List<UserAccount>listUser;
    private LayoutInflater layoutInflater;
    private Context context;

    public CustomListAdapter(List<UserAccount>listUser, Context context)
    {
        this.listUser = listUser;
        layoutInflater = LayoutInflater.from(context);
        this.context=context;
    }

    public int getCount(){
        return listUser.size();
    }

    public Object getItem(int position){
        return listUser.get(position);
    }

    public long getItemId(int position){
        return position;
    }

    public View getView(int position, View convertView, ViewGroup parent)
    {
        ViewHolder holder;
        if(convertView == null){
            convertView =
                    layoutInflater.inflate(R.layout.liste_item_layout ,null);
            holder = new ViewHolder();
            holder.rolePicView = (ImageView)
                    convertView.findViewById(R.id.imageView_role);
            holder.userNameView = (TextView)
                    convertView.findViewById(R.id.textView_name);
            holder.roleView = (TextView)
                    convertView.findViewById(R.id.textView_role);
            convertView.setTag(holder);
        } else {
            holder = (ViewHolder) convertView.getTag();
        }
        UserAccount user = this.listUser.get(position);
        holder.userNameView.setText(user.GetUserName());
        holder.roleView.setText("Role: "+ user.GetUserType());
        int imageId = this.getMipmapResIdByName(user.GetUserType());
        holder.rolePicView.setImageResource(imageId);
        return convertView;

    }

    public class ViewHolder {
        ImageView rolePicView;
        TextView userNameView;
        TextView roleView;
    }

    public int getMipmapResIdByName(String resName) {
        String pkgName = context.getPackageName();
        // Return 0 if not found.
        int resID = context.getResources().getIdentifier(resName , "mipmap",
                pkgName);
        Log.i("unliste", "Res Name: "+ resName+"==> Res ID = "+ resID);
        return resID;
    }

}
