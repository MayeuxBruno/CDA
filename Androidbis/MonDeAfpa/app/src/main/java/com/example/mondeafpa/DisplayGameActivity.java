package com.example.mondeafpa;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import java.util.Random;

public class DisplayGameActivity extends AppCompatActivity {
    Random random= new Random();
    String nbFaces;
    TextView textView;
    TextView phrase;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_display_game);
        textView = findViewById(R.id.textResult);
        phrase= findViewById(R.id.textIndic);
        Intent intent = getIntent();
        nbFaces = intent.getStringExtra(MainActivity.EXTRA_MESSAGE);
        int faces = Integer.parseInt(nbFaces);
        int aleatoire = random.nextInt((faces-1)+1)+1;
        textView.setText(Integer.toString(aleatoire));
        phrase.setText("Pour un dé à "+nbFaces+" faces");
     }

     public void lanceDe(View view)
     {
         int faces = Integer.parseInt(nbFaces);
         int aleatoire = random.nextInt((faces-1)+1)+1;
         textView.setText(Integer.toString(aleatoire));
         phrase.setText("Pour un dé à "+nbFaces+" faces");
     }
}