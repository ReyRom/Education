package com.example.practwork33.screens

import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.padding
import androidx.compose.material.Button
import androidx.compose.material.Scaffold
import androidx.compose.material.Text
import androidx.compose.material.TextField
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.compose.ui.unit.dp
import androidx.navigation.NavController

@Composable
fun Auth(navController: NavController) {
    Scaffold{
        var login = remember { mutableStateOf("") }
        var password = remember { mutableStateOf("") }
        Column(Modifier.padding(50.dp)) {
            Text(text = "Логин")
            TextField(value = login.value, onValueChange = {newText->login.value = newText})
            Text(text = "Пароль")
            TextField(value = password.value, onValueChange = {newText->password.value = newText})
            Button(onClick = {}) {
                Text(text = "Войти")
            }
            Button(onClick = {navController.navigate("reg")}) {
                Text(text = "Зарегистрироваться")
            }
        }
    }
}