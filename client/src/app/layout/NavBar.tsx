import {
  AppBar,
  Box,
  Container,
  LinearProgress,
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
        position="static"
        sx={{
          backgroundImage:
            "linear-gradient(135deg, #9b59b6 0%, #e91e63 70%, #f48fb1 90%)",
          position: "relative",
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
                <Typography variant="h4" fontWeight="bold">
                  Esto
                </Typography>
              </MenuItem>
            </Box>
            <Box sx={{ display: "flex" }}>
              <MenuItemLink to="/activities">Appointments</MenuItemLink>
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

        <Observer>
          {() =>
            uiStore.isLoading ? (
              <LinearProgress
                color="secondary"
                sx={{
                  position: "absolute",
                  bottom: 0,
                  left: 0,
                  right: 0,
                  height: 4,
                }}
              />
            ) : null
          }
        </Observer>
      </AppBar>
    </Box>
  );
}
