package com.example.applistview;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ListView listView = (ListView)findViewById(R.id.ListView);
        UserAccount francois = new UserAccount("Francois","admin");
        UserAccount germain = new UserAccount("Germain","user");
        UserAccount cedric = new UserAccount("Cédric","guest",false);

        UserAccount[] users = new UserAccount[]{francois,germain,cedric};

        ArrayAdapter<UserAccount> arrayAdapter = new ArrayAdapter<UserAccount>(this,android.R.layout.simple_list_item_1,users);

//        listView.setAdapter(arrayAdapter);
        listView.setAdapter(new CustomListAdapter(listCli, this));

        for (int i=0; i<users.length;i++)
        {
            listView.setItemChecked(i,users[i].isActive());
        }
    }
}