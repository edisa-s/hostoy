import {
  AppBar,
  Box,
  CircularProgress,
  Container,
  MenuItem,
  Toolbar,
  Typography,
} from "@mui/material";
import { Observer } from "mobx-react-lite";
import MenuItemLink from "../shared/components/MenuItemLink";
import { Group } from "@mui/icons-material";
import { NavLink } from "react-router";
import { useStore } from "../../lib/hooks/useStore";
import UserMenu from "./UserMenu";
import { useAccount } from "../../lib/hooks/useAccount";

export default function NavBar() {
  const { uiStore } = useStore();
  const { currentUser } = useAccount();

  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar
        position="fixed"
        sx={{
          backgroundImage:
            "linear-gradient(135deg, #b24592 0%, #f15f79 69%, #ff9a9e 89%)",
        }}
      >
        <Container maxWidth="xl">
          <Toolbar sx={{ display: "flex", justifyContent: "space-between" }}>
            <Box>
              <MenuItem
                component={NavLink}
                to="/"
                sx={{ display: "flex", gap: 2 }}
              >
                <Group fontSize="large" />
                <Typography
                  sx={{ position: "relative" }}
                  variant="h4"
                  fontWeight="bold"
                >
                  Estto
                </Typography>
                <Observer>
                  {() =>
                    uiStore.isLoading ? (
                      <CircularProgress
                        size={20}
                        thickness={7}
                        sx={{
                          color: "white",
                          position: "absolute",
                          top: "30%",
                          left: "105%",
                        }}
                      />
                    ) : null
                  }
                </Observer>
              </MenuItem>
            </Box>
            <Box sx={{ display: "flex" }}>
              <MenuItemLink to="/activities">Events</MenuItemLink>
              <Box display="flex" alignItems="center">
                {currentUser ? (
                  <UserMenu />
                ) : (
                  <>
                    <MenuItemLink to="/login">Login</MenuItemLink>
                    <MenuItemLink to="/register">Register</MenuItemLink>
                  </>
                )}
              </Box>
            </Box>
          </Toolbar>
        </Container>
      </AppBar>
    </Box>
  );
}
