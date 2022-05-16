package com.example.practwork33.screens

import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material.Scaffold
import androidx.compose.material.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.unit.dp
import androidx.navigation.NavController

@Composable
fun Users(navController: NavController) {
    Scaffold{
        val users=listOf("admin","editor","guest","editor","guest","editor","guest","editor","guest","editor","guest","editor","guest","editor","guest","editor","guest","editor","guest","editor","guest","editor","guest","editor","guest","editor","guest")
        LazyColumn {
            users.map {
                item {
                    Text(text = "$it", modifier = Modifier.padding(16.dp).fillMaxWidth().clickable {
                        val user = it
                        navController.navigate("details/" + user)
                    })
                }
            }
        }
    }
}