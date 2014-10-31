<?xml version="1.0" encoding="utf-8"?>
<LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
    android:orientation="vertical"
    android:layout_width="match_parent"
    android:layout_height="match_parent"
    android:divider="?android:attr/dividerHorizontal"
    android:showDividers="middle"
    android:background="@android:color/darker_gray">
    <TextView
        android:text="Title1"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:id="@+id/textView1"
        android:gravity="center"
        android:textSize="20dp"
        android:textStyle="bold"
        android:textColor="@android:color/black" />
    <View
        android:layout_width="wrap_content"
        android:layout_height="2dp"
        android:id="@+id/view1"
        android:background="@drawable/red_button" />
    <TextView
        android:text="Title2"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:id="@+id/textView2"
        android:gravity="center"
        android:textSize="15dp"
        android:textColor="@android:color/black" />
    <Button
        android:text="Button1"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:id="@+id/button1"
        style="?android:attr/borderlessButtonStyle"
        android:layout_marginTop="20dp"
        android:textColor="@android:color/black" />
    <Button
        android:text="Button2"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:id="@+id/button2"
        style="?android:attr/borderlessButtonStyle"
        android:textColor="@android:color/black" />
    <Button
        android:text="Button3"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:id="@+id/button3"
        style="?android:attr/borderlessButtonStyle"
        android:textColor="@android:color/black" />
    <Button
        android:text="Button4"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:id="@+id/button4"
        style="?android:attr/borderlessButtonStyle"
        android:textColor="@android:color/black" />
    <Button
        android:text="Button5"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:id="@+id/button5"
        style="?android:attr/borderlessButtonStyle"
        android:textColor="@android:color/black" />
    <TextView
        android:layout_width="wrap_content"
        android:layout_height="90dp"
        android:layout_weight="1"
        android:gravity="center_vertical"
        android:text="  Simple text here?"
        android:textColor="@color/blue"
        android:layout_marginBottom="0dp"
        android:layout_gravity="center" />
    <LinearLayout
        style="?android:attr/buttonBarStyle"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:orientation="horizontal">
        <Button
            style="?android:attr/buttonBarButtonStyle"
            android:layout_width="0dp"
            android:layout_height="wrap_content"
            android:layout_weight="1"
            android:text="Login"
            android:textColor="@android:color/white"
            android:background="@drawable/blueButton" />
        <Button
            style="?android:attr/buttonBarButtonStyle"
            android:layout_width="0dp"
            android:layout_height="wrap_content"
            android:layout_weight="1"
            android:text="Register"
            android:textColor="@android:color/white"
            android:background="@drawable/blueButton" />
    </LinearLayout>
</LinearLayout>
