import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';
import {useAuth0} from '../auth0-wrapper';

const Navmenu = () => {
  const {isAuthenticated, loginWithRedirect, logout } = useAuth0();

  return (
    <header>
      <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
        <Container>
          <NavbarBrand tag={Link} to="/">TripPlanner</NavbarBrand>

            {isAuthenticated ? (
              <ul className="navbar-nav flex-grow">
              <NavItem>
                  <NavLink tag={Link} className="text-dark" to="/create">Create</NavLink>
                </NavItem>
                <NavItem>
                  <NavLink tag={Link} className="text-dark" to="/trips">Trips</NavLink>
                </NavItem>
                <NavItem>
                  <button className="tbtn btn-danger" onClick={() => logout()} >Log out </button>
                </NavItem>
              </ul>
            ) : (
              <ul className="navbar-nav flex-grow">
                <NavItem>
                  <button className="tbtn btn-success" onClick={() => loginWithRedirect()} >Login </button>
                </NavItem>
              </ul>
            )}



        </Container>
      </Navbar>
    </header>
  );
}

export default Navmenu;