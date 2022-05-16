package com.example.practwork33

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.material.*
import androidx.compose.ui.Modifier
import androidx.navigation.NavType
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.rememberNavController
import androidx.navigation.navArgument
import com.example.practwork33.ui.theme.PractWork33Theme
import com.example.practwork33.screens.Auth
import com.example.practwork33.screens.Details
import com.example.practwork33.screens.Reg
import com.example.practwork33.screens.Users

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            PractWork33Theme {
                // A surface container using the 'background' color from the theme
                Surface(
                    modifier = Modifier.fillMaxSize(),
                    color = MaterialTheme.colors.background
                ) {
                    val bottomItems = listOf("auth", "reg", "users", "details")
                    val navController = rememberNavController()
                    Scaffold(
                        bottomBar = {
                            BottomNavigation {
                                bottomItems.forEach { screen ->
                                    BottomNavigationItem(selected = false,
                                        onClick = { navController.navigate(screen) },
                                        label = { Text(screen) },
                                        icon = {}
                                    )
                                }
                            }
                        }
                    ) {
                        NavHost(
                            navController = navController,
                            startDestination = "auth"
                        ) {
                            composable("auth") {
                                Auth(navController)
                            }
                            composable("reg") {
                                Reg(navController)
                            }
                            composable("users") {
                                Users(navController)
                            }
                            composable(
                                "details/{login}",
                                arguments = listOf(navArgument("login") {
                                    type = NavType.StringType
                                })
                            ) { backStackEntry ->
                                Details(backStackEntry.arguments?.getString("login").toString())
                            }
                        }
                    }
                }
            }
        }
    }
}